using UnityEngine;
using LLNet;
using GameSavvy.Byterizer;

[CreateAssetMenu(menuName = "LLNet/Messages/UserInfo")]
public class Message_UserInfo : ANetMessage
{
    private void OnEnable()
    {
        MessageType = NetMessageType.USER_INFO;
    }

    public override void Client_ReceiveMessage(ByteStream data, LLClient client)
    {
        var conId = data.PopInt32();
        var userName = data.PopString();
        var teamNum = data.PopInt32();

        var newUser = new NetUser()
        {
            ConnectionID = conId,
            UserName = userName,
            TeamNumber = teamNum
        };

        client.NetUsers[conId] = newUser;

        // var msg = new ByteStream();
        // msg.Encode
        // (
        //     (byte)NetMessageType.USER_INFO,
        //     client.UserName,
        //     client.TeamNumber
        // );
        // client.SendNetMessage(client.ReliableChannel, msg.ToArray());

        Debug.Log($"@Client -> MyConnectionId [{conId}]");
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        server.NetUsers[connectionId].UserName = data.PopString();
        server.NetUsers[connectionId].TeamNumber = data.PopInt32();

        // BC this user's info to other users
        var msgData = new ByteStream();
        msgData.Encode
        (
            (byte)NetMessageType.USER_INFO,
            connectionId,
            server.NetUsers[connectionId].UserName,
            server.NetUsers[connectionId].TeamNumber
        );

        server.BroadcastNetMessage(server.ReliableChannel, msgData.ToArray(), connectionId);

        // Send other user's info to this user
        foreach (var user in server.NetUsers)
        {
            if (user.Key == connectionId) continue;
            msgData = new ByteStream();
            msgData.Encode
            (
                (byte)NetMessageType.USER_INFO,
                user.Value.ConnectionID,
                user.Value.UserName,
                user.Value.TeamNumber
            );
            server.SendNetMessage(connectionId, server.ReliableChannel, msgData.ToArray());
        }

        Debug.Log($"@Server -> User[{connectionId}, {server.NetUsers[connectionId].UserName}, {server.NetUsers[connectionId].TeamNumber}] registered");
    }
}
