using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LLServer : MonoBehaviour
{
    [SerializeField] private int _serverPort = 27000;
    [SerializeField] private int _bufferSize = 1024;
    [SerializeField] private byte _threadPoolSize = 3;

    private byte _reliableChannel;
    private byte _unreliableChannel;
    private int _socketId = 0;

    private void Start() {
        StartServer();
    }

    private void StartServer()
    {
        GlobalConfig globalConfig = new GlobalConfig()
        {
            ThreadPoolSize = _threadPoolSize
        };

        NetworkTransport.Init(globalConfig);

        ConnectionConfig connectionConfig = new ConnectionConfig()
        {
            SendDelay = 0,
            MinUpdateTimeout = 1
        };

        _reliableChannel = connectionConfig.AddChannel(QosType.Reliable);
        _unreliableChannel = connectionConfig.AddChannel(QosType.Unreliable);

        HostTopology hostTopology = new HostTopology(connectionConfig, 16);
        _socketId = NetworkTransport.AddHost(hostTopology, _serverPort);

        StartCoroutine(Receiver());

        Debug.Log($"@StartServer -> {_socketId}");
    }

    private IEnumerator Receiver()
    {
        int receiveSocketId, receiveConnectionId, receiveChannelId, receiverDataSize;
        byte error;
        byte[] receiveBuffer = new byte[_bufferSize];

        while(true)
        {
            var netEventType = NetworkTransport.Receive
            (
                out receiveSocketId,
                out receiveConnectionId,
                out receiveChannelId,
                receiveBuffer,
                _bufferSize,
                out receiverDataSize,
                out error
            );

            switch(netEventType)
            {
                case NetworkEventType.Nothing:
                {
                    yield return null;
                    break;
                }

                case NetworkEventType.DataEvent:
                {
                    NetworkTransport.Send(_socketId, receiveConnectionId, _reliableChannel, receiveBuffer, receiverDataSize, out error);
                    break;
                }

                case NetworkEventType.ConnectEvent:
                {
                    Debug.Log($"@Receiver.Connect -> Socket = [{receiveSocketId}], UserId = [{receiveConnectionId}]");
                    break;
                }

                case NetworkEventType.DisconnectEvent:
                {
                    Debug.Log($"@Receiver.Disconnect -> Socket = [{receiveSocketId}], UserId = [{receiveConnectionId}]");
                    break;
                }

                default:
                {
                    Debug.Log($"@Receiver -> Unrecognized Network Message Type = [{netEventType.ToString()}]");
                    break;
                }
            }
        }
    }
}
