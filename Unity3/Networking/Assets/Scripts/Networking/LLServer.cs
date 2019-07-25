using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using GameSavvy;
using GameSavvy.Byterizer;

namespace LLNet
{
    public class LLServer : MonoBehaviour
    {
        public Dictionary<int, NetUser> NetUsers { get; private set; }
        public byte ReliableChannel { get; private set; }
        public byte UnreliableChannel { get; private set; }
        private int _SocketId = 0;
        public GameObject playerPrefab;

        [SerializeField]
        private int _ServerPort = 27000;

        [SerializeField]
        private int _BufferSize = 1024;

        [SerializeField]
        private byte _ThreadPoolSize = 3;

        [SerializeField]
        private NetMessageContainer _NetMessages;


        private void Start()
        {
            StartServer();
        }

        private void StartServer()
        {
            NetUsers = new Dictionary<int, NetUser>();
            GlobalConfig globalConfig = new GlobalConfig()
            {
                ThreadPoolSize = _ThreadPoolSize
            };

            NetworkTransport.Init(globalConfig);

            ConnectionConfig connectionConfig = new ConnectionConfig()
            {
                SendDelay = 0,
                MinUpdateTimeout = 1
            };
            ReliableChannel = connectionConfig.AddChannel(QosType.Reliable);
            UnreliableChannel = connectionConfig.AddChannel(QosType.Unreliable);

            HostTopology hostTopology = new HostTopology(connectionConfig, 16);
            _SocketId = NetworkTransport.AddHost(hostTopology, _ServerPort);

            StartCoroutine(Receiver());

            Debug.Log($"@StartServer -> {_SocketId}");
        }

        private IEnumerator Receiver()
        {
            int recSocketId, recConnectionId, recChannelId, recDataSize;
            byte error;
            byte[] recBuffer = new byte[_BufferSize];

            while (true)
            {
                var netEventType = NetworkTransport.Receive
                (
                    out recSocketId,
                    out recConnectionId,
                    out recChannelId,
                    recBuffer,
                    _BufferSize,
                    out recDataSize,
                    out error
                );

                switch (netEventType)
                {
                    case NetworkEventType.Nothing:
                        {
                            yield return null;
                            break;
                        }

                    case NetworkEventType.DataEvent:
                        {
                            OnDataEvent(recConnectionId, recChannelId, recBuffer, recDataSize);
                            break;
                        }

                    case NetworkEventType.ConnectEvent:
                        {
                            OnConnectedEvent(recConnectionId);
                            break;
                        }

                    case NetworkEventType.DisconnectEvent:
                        {
                            OnDisconnectedEvent(recConnectionId);
                            break;
                        }

                    default:
                        {
                            Debug.Log($"@Receiver -> Unrecognized Net Message Type [{netEventType.ToString()}]");
                            break;
                        }
                }
            }
        }

        private void OnConnectedEvent(int connectionId)
        {
            if (NetUsers.ContainsKey(connectionId))
            {
                Debug.Log($"@Receiver.Connect -> userId = [{connectionId}] Re-Conneted");
            }
            else
            {
                var newUser = new NetUser() { ConnectionID = connectionId };
                NetUsers[connectionId] = newUser;
                Debug.Log($"@Receiver.Connect -> userId = [{connectionId}]");
            }

            var byteStream = new ByteStream();
            byteStream.Append((byte)NetMessageType.CONNECTION_ACK);
            byteStream.Append(connectionId);

            SendNetMessage(connectionId, ReliableChannel, byteStream.ToArray());
        }

        private void OnDisconnectedEvent(int recConnectionId)
        {
            Destroy(NetUsers[recConnectionId].PlayerObject);
            NetUsers.Remove(recConnectionId);
            Debug.Log($"@Receiver.Disconnect -> userId = [{recConnectionId}]");

            var byteStream = new ByteStream();
            byteStream.Append((byte)NetMessageType.DISCONNECTION_ACK);
            byteStream.Append(recConnectionId);

            BroadcastNetMessage(ReliableChannel, byteStream.ToArray());
        }

        private void OnDataEvent(int recConnectionId, int recChannelId, byte[] data, int dataSize)
        {
            var msgData = new ByteStream(data, dataSize);
            NetMessageType msgType = (NetMessageType)msgData.PopByte();
            Debug.Log($"Server OnDataEvent {msgType}");

            _NetMessages.NetMessagesMap[msgType].Server_ReceiveMessage(recConnectionId, msgData, this);
        }

        public void SendNetMessage(int targetId, byte channelId, byte[] data)
        {
            //byte[] data = System.Text.Encoding.UTF8.GetBytes(msg);
            NetworkTransport.Send
            (
                _SocketId,
                targetId,
                channelId,
                data,
                data.Length,
                out var error
            );

            if (error != 0)
            {
                Debug.LogError($"@Server -> Error: [{error}] : Could Not Send Message To Client [{targetId}]");
            }
        }

        public void BroadcastNetMessage(byte channelId, byte[] data, int excludeId = -1)
        {
            foreach (var user in NetUsers)
            {
                if (user.Key == excludeId) continue;

                NetworkTransport.Send
                (
                    _SocketId,
                    user.Key,
                    channelId,
                    data,
                    data.Length,
                    out var error
                );

                if (error != 0)
                {
                    Debug.LogError($"@Server -> Error: [{error}] : Could Not Send Message To Client [{user.Key}]");
                }
            }
        }

        public void MulticastNetMessage(int targetTeam, byte channelId, byte[] data, int excludeId = -1)
        {
            //byte[] data = System.Text.Encoding.UTF8.GetBytes(msg);

            foreach (var user in NetUsers)
            {
                if (user.Key == excludeId) continue;

                if (user.Value.TeamNumber == targetTeam)
                {
                    NetworkTransport.Send
                    (
                    _SocketId,
                    user.Key,
                    channelId,
                    data,
                    data.Length,
                    out var error
                    );

                    if (error != 0)
                    {
                        Debug.LogError($"@Server -> Error: [{error}] : Could Not Send Message To Client [{user.Key}]");
                    }
                }
            }
        }
        
        private void OnGUI()
        {
            GUILayout.Space(32);
            GUILayout.Label("Users Connected");
            GUILayout.Space(32);
            foreach (var user in NetUsers)
            {
                if (GUILayout.Button($"{user.Key} - {user.Value.UserName}"))
                {
                    //Kick the player
                    NetworkTransport.Disconnect(_SocketId, user.Key, out var err);
                }
            }
        }

    }//Class

}// Namescape