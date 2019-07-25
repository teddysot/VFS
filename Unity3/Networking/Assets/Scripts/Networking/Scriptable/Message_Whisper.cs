using GameSavvy.Byterizer;
using LLNet;
using UnityEngine;

[CreateAssetMenu(menuName = "LLNet/Messages/Whisper")]
public class Message_Whisper : ANetMessage
{
    private void OnEnable()
    {
        MessageType = NetMessageType.CHAT_WHISPER;
    }

    public override void Client_ReceiveMessage(ByteStream data, LLClient client)
    {
        var targetUser = data.PopInt32();
        var msg = data.PopString();
        var sender = data.PopInt32();
        client.AddMessageToQueue($"[Whisper from {client.NetUsers[sender].UserName}] {msg}");
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        var targetId = data.PopInt32();
        data.Append(connectionId);

        server.SendNetMessage(targetId, server.ReliableChannel, data.ToArray());
    }
}
