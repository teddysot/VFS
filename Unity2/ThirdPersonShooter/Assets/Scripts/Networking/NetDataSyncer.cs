using Photon.Pun;
using UnityEngine;

public class NetDataSyncer : MonoBehaviourPun, IPunObservable
{
    [SerializeField] private float _smoothFactor = 0.5f;
    private Vector3 _netPos;
    private Quaternion _netRot;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.IsWriting) // We are sending data
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        {
            _netPos = (Vector3)stream.ReceiveNext();
            transform.rotation = (Quaternion)stream.ReceiveNext();
        }
    }

    private void Update()
    {
        if(photonView.IsMine)
        {
            return;
        }
        transform.position = Vector3.Lerp(transform.position, _netPos, Time.deltaTime * _smoothFactor);
    }
    
    [PunRPC]
    public void RPC_SetTeam(int team)
    {
        GetComponent<Unit>().SetTeam(team);
    }
}
