using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class NetComponentController : MonoBehaviour
{
    [SerializeField] private GameObject[] _objectsToDelete;
    [SerializeField] private Component[] _componentsToRemove;

    private void Awake()
    {
        if(GetComponent<PhotonView>().IsMine == false)
        {
            foreach(var item in _objectsToDelete)
            {
                Destroy(item);
            }

            foreach(var item in _componentsToRemove)
            {
                Destroy(item);
            }
        }
    }
}
