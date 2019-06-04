using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFanSpeed : MonoBehaviour
{
    [SerializeField] private GameObject[] _speed;

    // Update is called once per frame
    void Update()
    {
        int speed = ACData.fanSpeed;
        for(int i = 0; i < speed; i++)
        {
            _speed[i].SetActive(true);
        }

        if(speed < _speed.Length)
        {
            for(int i = speed; i < _speed.Length; i++)
            {
                _speed[i].SetActive(false);
            }
        }
    }
}
