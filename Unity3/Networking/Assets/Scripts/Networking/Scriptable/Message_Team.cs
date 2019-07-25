using GameSavvy.Byterizer;
using LLNet;
using UnityEngine;

[CreateAssetMenu(menuName = "LLNet/Messages/Team")]
public class Message_Team : ANetMessage
{
    private void OnEnable()
    {
        MessageType = NetMessageType.CHAT_TEAM_MESSAGE;
    }

    public override void Client_ReceiveMessage(ByteStream data, LLClient client)
    {
        var sender = data.PopInt32();
        var msg = data.PopString();

        Debug.Log($"Msgs: {data.ToString()}");

        client.AddMessageToQueue($"[TEAM from {client.NetUsers[sender].UserName}] {msg}");
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        var targetId = data.PopInt32();
        server.MulticastNetMessage(targetId, server.ReliableChannel, data.ToArray(), connectionId);
    }
}
