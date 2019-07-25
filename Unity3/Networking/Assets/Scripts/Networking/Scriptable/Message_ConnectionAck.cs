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

        var msg = new ByteStream();
        msg.Encode
        (
            (byte)NetMessageType.USER_INFO,
            client.UserName,
            client.TeamNumber
        );

        client.SendNetMessage(client.ReliableChannel, msg.ToArray());

        var playerClone = Instantiate(client.playerPrefab, Vector3.zero, Quaternion.identity);

        client.NetUsers[conId].PlayerObject = playerClone;

        var msg2 = new ByteStream();
        msg2.Encode
        (
            (byte)NetMessageType.SPAWN_PLAYER,
            playerClone.transform.position,
            playerClone.transform.rotation
        );

        client.SendNetMessage(client.ReliableChannel, msg2.ToArray());

        Debug.Log($"{client.UserName} Send Spawn Message");

        Debug.Log($"@Client -> MyConnectionId [{conId}]");
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        // Never get called
    }
}
