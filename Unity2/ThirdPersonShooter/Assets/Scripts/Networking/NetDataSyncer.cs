using Photon.Pun;
using UnityEngine;

public class NetDataSyncer : MonoBehaviourPun, IPunObservable
{
    [SerializeField]
    private float _SmoothFactor = 0.5f;

    private Vector3 _NetPos;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.IsWriting) //We are sending data
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        {
            _NetPos = (Vector3)stream.ReceiveNext();
            transform.rotation = (Quaternion)stream.ReceiveNext();
        }
    }

    private void Update()
    {
        if(photonView.IsMine) return;
        transform.position = Vector3.Lerp(transform.position, _NetPos, Time.deltaTime * _SmoothFactor);
    }

    [PunRPC]
    public void RPC_SetTeam(int team)
    {
        GetComponent<Unit>().SetTeam(team);
    }

}
