﻿using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class NetComponentController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _ObjectsToDelete;

    [SerializeField]
    private Component[] _ComponentsToRemove;

    private void Awake()
    {
        if(GetComponent<PhotonView>().IsMine == false)
        {
            foreach (var item in _ObjectsToDelete)
            {
                Destroy(item);
            }
            foreach (var item in _ComponentsToRemove)
            {
                Destroy(item);
            }
        }
    }
    

}
