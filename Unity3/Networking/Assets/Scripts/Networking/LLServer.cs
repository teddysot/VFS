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
        [SerializeField]
        private int _ServerPort = 27000;

        [SerializeField]
        private int _BufferSize = 1024;

        [SerializeField]
        private byte _ThreadPoolSize = 3;

        private byte _ReliableChannel;
        private byte _UnreliableChannel;
        private int _SocketId = 0;
        private Dictionary<int, NetUser> _NetUsers = new Dictionary<int, NetUser>();

        private void Start()
        {
            StartServer();
        }

        private void StartServer()
        {
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
            _ReliableChannel = connectionConfig.AddChannel(QosType.Reliable);
            _UnreliableChannel = connectionConfig.AddChannel(QosType.Unreliable);

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
            if (_NetUsers.ContainsKey(connectionId))
            {
                Debug.Log($"@Receiver.Connect -> userId = [{connectionId}] Re-Conneted");
            }
            else
            {
                var newUser = new NetUser() { ConnectionID = connectionId };
                _NetUsers[connectionId] = newUser;
                Debug.Log($"@Receiver.Connect -> userId = [{connectionId}]");
            }

            //var msg = $"CONNECTION_ACK|{connectionId}";

            var byteStream = new ByteStream();
            byteStream.Append((byte)NetMessageType.CONNECTION_ACK);
            byteStream.Append(connectionId);

            SendNetMessage(connectionId, _ReliableChannel, byteStream.ToArray());
        }

        private void OnDisconnectedEvent(int recConnectionId)
        {
            _NetUsers.Remove(recConnectionId);
            Debug.Log($"@Receiver.Disconnect -> userId = [{recConnectionId}]");

            //var msg = $"DISCONNECTION_ACK|{recConnectionId}";
            var byteStream = new ByteStream();
            byteStream.Append((byte)NetMessageType.DISCONNECTION_ACK);
            byteStream.Append(recConnectionId);

            OnChatBroadcast(recConnectionId, byteStream);
        }

        private void OnDataEvent(int recConnectionId, int recChannelId, byte[] data, int dataSize)
        {
            //string msg = System.Text.Encoding.UTF8.GetString(data, 0, dataSize);
            //string[] msgData = msg.Split('|');
            var byteStream = new ByteStream(data, dataSize);
            NetMessageType msgType = (NetMessageType)byteStream.PopByte();

            Debug.Log($"MsgServer: {msgType}");
            switch (msgType)
            {
                case NetMessageType.USER_INFO:
                    {
                        OnUserInfo(recConnectionId, byteStream);
                        break;
                    }

                case NetMessageType.CHAT_WHISPER:
                    {
                        OnChatWhisper(recConnectionId, byteStream);
                        break;
                    }

                case NetMessageType.CHAT_BROADCAST:
                    {
                        OnChatBroadcast(recConnectionId, byteStream);
                        break;
                    }

                case NetMessageType.CHAT_TEAM_MESSAGE:
                    {
                        OnChatTeam(recConnectionId, byteStream);
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        private void OnChatBroadcast(int conId, ByteStream byteStream)
        {
            byteStream.PopString();
            BroadcastNetMessage(_ReliableChannel, byteStream.ToArray(), conId);
        }

        private void OnChatWhisper(int conId, ByteStream byteStream)
        {
            var targetId = byteStream.PopInt32();
            byteStream.Append(conId);

            SendNetMessage(targetId, _ReliableChannel, byteStream.ToArray());
        }

        private void OnChatTeam(int conId, ByteStream byteStream)
        {
            //int.TryParse(targetTeamId, out var targetId);
            //msg = $"TEAM|{conId}";
            //msg += "|" + msg;
            var targetId = byteStream.PopInt32();
            MulticastNetMessage(targetId, _ReliableChannel, byteStream.ToArray(), conId);
        }

        private void OnUserInfo(int conId, ByteStream byteStream)
        {
            _NetUsers[conId].UserName = byteStream.PopString();
            _NetUsers[conId].TeamNumber = byteStream.PopInt32();

            var msgData = new ByteStream();
            msgData.Encode
            (
                (byte)NetMessageType.USER_INFO,
                conId,
                _NetUsers[conId].UserName,
                _NetUsers[conId].TeamNumber
            );

            // BC this user's info to other users
            var msg = $"USER_INFO|{conId}|{_NetUsers[conId].UserName}|{_NetUsers[conId].TeamNumber}";
            BroadcastNetMessage(_ReliableChannel, msgData.ToArray(), conId);

            // Send other user's info to this user
            foreach (var user in _NetUsers)
            {
                if (user.Key == conId) continue;
                //msg = $"USER_INFO|{user.Key}|{user.Value.UserName}|{user.Value.TeamNumber}";
                msgData = new ByteStream();
                msgData.Encode
                (
                    (byte)NetMessageType.USER_INFO,
                    user.Value.ConnectionID,
                    user.Value.UserName,
                    user.Value.TeamNumber
                );
                SendNetMessage(conId, _ReliableChannel, msgData.ToArray());
            }

            Debug.Log($"@Server -> User[{conId}, {_NetUsers[conId].UserName}, {_NetUsers[conId].TeamNumber}] registered");
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
            foreach (var user in _NetUsers)
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

            foreach (var user in _NetUsers)
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
            foreach (var user in _NetUsers)
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