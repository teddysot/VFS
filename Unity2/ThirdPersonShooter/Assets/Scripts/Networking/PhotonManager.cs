using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private string _NickName = "Dude";

    [SerializeField]
    private int _TeamNumber = 0;

    private void Start()
    {
        // PhotonNetwork.SendRate = 60;
        // PhotonNetwork.SerializationRate = 20;
        PhotonNetwork.NickName = _NickName;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print($"OnConnectedToMaster, MyID {PhotonNetwork.LocalPlayer.UserId}");

        RoomOptions roomOptions = new RoomOptions()
        {
            MaxPlayers = 20,
            IsVisible = true,
            IsOpen = true,
            PublishUserId = true
        };
        PhotonNetwork.JoinOrCreateRoom("PG15", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        print($"OnJoinedRoom [{PhotonNetwork.CurrentRoom.Name}]");
        var clone = PhotonNetwork.Instantiate("Net_NightShade", transform.position, transform.rotation);
        PhotonView.Get(clone).RPC("RPC_SetTeam", RpcTarget.AllBuffered, _TeamNumber);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        print($"[{newPlayer.NickName}] Joined our Room");
    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        print($"New master client is [{newMasterClient.NickName}]");
    }


}
