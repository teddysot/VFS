using UnityEngine;
using LLNet;
using GameSavvy.Byterizer;

[CreateAssetMenu(menuName = "LLNet/Messages/SpawnPlayer")]
public class Message_SpawnPlayer : ANetMessage
{
    private void OnEnable()
    {
        MessageType = NetMessageType.SPAWN_PLAYER;
    }

    public override void Client_ReceiveMessage(ByteStream data, LLClient client)
    {
        var conId = data.PopInt32();
        var position = data.PopVector3();
        var rotation = data.PopQuaternion();

        var meUser = new NetUser()
        {
            ConnectionID = conId,
        };

        client.NetUsers[conId] = meUser;
        client.MyConnectionId = conId;

        var player = Instantiate(client.playerPrefab, position, rotation);
        client.NetUsers[conId].PlayerObject = player;

        var msg = new ByteStream();
        msg.Encode
        (
            (byte)NetMessageType.SPAWN_PLAYER,
            client.NetUsers[conId].PlayerObject.transform.position,
            client.NetUsers[conId].PlayerObject.transform.rotation
        );
        client.SendNetMessage(client.ReliableChannel, msg.ToArray());

        Debug.Log($"{client.UserName} spawned!");
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        var position = data.PopVector3();
        var rotation = data.PopQuaternion();

        server.NetUsers[connectionId].PlayerObject = Instantiate(server.playerPrefab, position, rotation);

        Debug.Log($"Server {server.NetUsers[connectionId].UserName} Receive Spawn Message");

        var msgData = new ByteStream();

        // Send other user's info to this user
        foreach (var user in server.NetUsers)
        {
            if (user.Key == connectionId) continue;

            msgData = new ByteStream();
            msgData.Encode
            (
                (byte)NetMessageType.SPAWN_PLAYER,
                user.Value.ConnectionID,
                server.NetUsers[connectionId].PlayerObject.transform.position,
                server.NetUsers[connectionId].PlayerObject.transform.rotation
            );
            server.SendNetMessage(connectionId, server.ReliableChannel, msgData.ToArray());
        }
    }
}
