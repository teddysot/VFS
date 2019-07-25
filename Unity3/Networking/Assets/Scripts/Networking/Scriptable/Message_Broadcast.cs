using GameSavvy.Byterizer;
using LLNet;
using UnityEngine;

[CreateAssetMenu(menuName = "LLNet/Messages/Broadcast")]
public class Message_Broadcast : ANetMessage
{
    private void OnEnable()
    {
        MessageType = NetMessageType.CHAT_BROADCAST;
    }

    public override void Client_ReceiveMessage(ByteStream data, LLClient client)
    {
        var msg = data.PopString();
        var sender = data.PopInt32();
        client.AddMessageToQueue($"[BC from {client.NetUsers[sender].UserName}] {msg}");
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        data.Append(connectionId);
        server.BroadcastNetMessage(server.ReliableChannel, data.ToArray(), connectionId);
    }
}
