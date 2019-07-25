using GameSavvy.Byterizer;
using LLNet;
using UnityEngine;

[CreateAssetMenu(menuName = "LLNet/Messages/DisconnectionAck")]
public class Message_DisconnectionAck : ANetMessage
{
    private void OnEnable()
    {
        MessageType = NetMessageType.DISCONNECTION_ACK;
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

            var msg = new ByteStream();
            msg.Encode
            (
                (byte)NetMessageType.DISCONNECTION_ACK,
                client.UserName,
                client.TeamNumber
            );

            Destroy(client.NetUsers[conId].PlayerObject);
            client.NetUsers.Remove(conId);

            Debug.Log($"@Client -> DisconnectId [{conId}]");
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        // Never get called
    }
}
