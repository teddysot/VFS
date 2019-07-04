using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LLClient : MonoBehaviour
{
    [SerializeField] private string _serverAddress = "127.0.0.1";
    [SerializeField] private int _serverPort = 27000;
    [SerializeField] private int _bufferSize = 1024;
    [SerializeField] private byte _threadPoolSize = 3;

    private byte _reliableChannel;
    private byte _unreliableChannel;
    private int _socketId = 0;
    private int _serverConnectionId = 0;

    private void Start()
    {
        ConnectToServer();
        InvokeRepeating("Pinger", 1.0f, 1.0f);
    }

    private void ConnectToServer()
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
        _socketId = NetworkTransport.AddHost(hostTopology, 0);

        byte error;
        _serverConnectionId = NetworkTransport.Connect(_socketId, _serverAddress, _serverPort, 0, out error);

        if (error == 0)
        {
            StartCoroutine(Receiver());
            Debug.Log($"@ConnectToServer -> {_socketId} - {_serverConnectionId}");
        }
        else
        {
            Debug.LogError($"@ConnectToServer -> {error}");
        }
    }

    private IEnumerator Receiver()
    {
        int receiveSocketId, receiveConnectionId, receiveChannelId, receiverDataSize;
        byte error;
        byte[] receiveBuffer = new byte[_bufferSize];

        while (true)
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

            switch (netEventType)
            {
                case NetworkEventType.Nothing:
                    {
                        yield return null;
                        break;
                    }

                case NetworkEventType.DataEvent:
                    {
                        double timeSpan = DateTime.UtcNow.Ticks - BitConverter.ToInt64(receiveBuffer, 0);
                        _immediatePing = (float)(timeSpan/10000f);
                        _totalPing += _immediatePing;
                        ++_pingCount;
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

    private void Pinger()
    {
        byte [] data = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
        byte error;
        NetworkTransport.Send(_socketId, _serverConnectionId, _reliableChannel, data, data.Length, out error);
        if(error != 0)
        {
            Debug.LogError($"@Pinger -> Error Sending message [{error}]");
        }
    }

    private float _immediatePing;
    private float _totalPing;
    private int _pingCount;
    private void OnGUI() 
    {
        float averagePing = _totalPing/(float)_pingCount;
        GUILayout.Label($"  [ {averagePing} ]   -   [ {_immediatePing} ]");
    }
}
