using UnityEngine;
using LLNet;
using GameSavvy.Byterizer;

[CreateAssetMenu(menuName = "LLNet/Messages/ConnectionAck")]
public class Message_ConnectionAck : ANetMessage
{
    private void OnEnable() 
    {
        MessageType = NetMessageType.CONNECTION_ACK;
    }

    public override void Client_ReceiveMessage(ByteStream data, LLClient client)
    {
        var conId = data.PopInt32();

            var meUser = new NetUser()
            {
                ConnectionID = conId,
                UserName = client.UserName,
                TeamNumber = client.TeamNumber
            };

            client.NetUsers[conId] = meUser;
            client.MyConnectionId = conId;

            //var msg = $"USER_INFO|{_UserName}|{_TeamNumber}";

            var msg = new ByteStream();
            msg.Encode
            (
                (byte)NetMessageType.USER_INFO,
                client.UserName,
                client.TeamNumber
            );
            client.SendNetMessage(client.ReliableChannel, msg.ToArray());

            Debug.Log($"@Client -> MyConnectionId [{conId}]");
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        // Never get called
    }
}
