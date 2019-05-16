using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private string _nickname = "Dude";

    [SerializeField] private int _teamNumber;

    private void Start()
    {
        // PhotonNetwork.SendRate = 60;
        // PhotonNetwork.SerializationRate = 20;
        PhotonNetwork.NickName = _nickname;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print($"OnConnectedToMaster, MyID {PhotonNetwork.LocalPlayer.UserId}");

        RoomOptions roomOptions = new RoomOptions()
        {
            MaxPlayers = 20,
            IsVisible = true,
            IsOpen = true
        };

        PhotonNetwork.JoinOrCreateRoom("PG15", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        print($"OnJoinedRoom [{PhotonNetwork.CurrentRoom.Name}]");

        var clone = PhotonNetwork.Instantiate("Net_NightShade", transform.position, transform.rotation);
        PhotonView.Get(clone).RPC("RPC_SetTeam", RpcTarget.AllBuffered, _teamNumber);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        print($"[{newPlayer.NickName}, {newPlayer.UserId}] Joined our Room");
    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        print($"OnMasterClientSwitched Master: [{newMasterClient.NickName}]");
    }
}
