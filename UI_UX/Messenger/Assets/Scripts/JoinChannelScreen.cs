using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinChannelScreen : MonoBehaviour
{
    [SerializeField] private GameObject _channelScreen;
    public void JoinChannel()
    {
        Instantiate(_channelScreen, transform.position, Quaternion.identity);
    }

    public void Cancel()
    {
        Destroy(gameObject);
    }
}
