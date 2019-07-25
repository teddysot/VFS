using GameSavvy.Byterizer;
using LLNet;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "LLNet/Messages/PlayerMove")]
public class Message_PlayerMove : ANetMessage
{
    private void OnEnable()
    {
        MessageType = NetMessageType.PLAYER_MOVE;
    }

    public override void Client_ReceiveMessage(ByteStream data, LLClient client)
    {
        var connectionId = data.PopInt32();

        var player = client.NetUsers[connectionId].PlayerObject.GetComponent<NavMeshAgent>();
        player.SetDestination(player.transform.position + Vector3.forward * 10);
    }

    public override void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server)
    {
        var player = server.NetUsers[connectionId].PlayerObject.GetComponent<NavMeshAgent>();
        player.SetDestination(player.transform.position + Vector3.forward * 10);

        var msgData = new ByteStream();

        // Send other user's info to this user
        foreach (var user in server.NetUsers)
        {
            msgData.Encode
            (
                (byte)NetMessageType.PLAYER_MOVE,
                user.Value.ConnectionID
            );
            server.SendNetMessage(connectionId, server.ReliableChannel, msgData.ToArray());
        }
    }
}
