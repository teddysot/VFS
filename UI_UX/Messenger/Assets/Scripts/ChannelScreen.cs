using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChannelScreen : MonoBehaviour
{
    [SerializeField] private GameObject _screens;
    [SerializeField] private AudioClip[] _clips;
    
    private int _screen = 1;
    private AudioSource _audio;

    private void Start() 
    {
        _audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _screen = 1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _screen = 2;
        }

        if (_screen == 1)
        {
            _screens.transform.localPosition = new Vector3(Mathf.Lerp(_screens.transform.localPosition.x, 0.0f, Time.deltaTime), 0.0f, 0.0f);
        }
        else if (_screen == 2)
        {
            _screens.transform.localPosition = new Vector3(Mathf.Lerp(_screens.transform.localPosition.x, -598.0f, Time.deltaTime), 0.0f, 0.0f);
        }
    }
    public void TopClick()
    {
        _audio.clip = _clips[0];
        _audio.Play();
    }

    public void MidClick()
    {
        _audio.clip = _clips[1];
        _audio.Play();
    }

    public void BotClick()
    {
        _audio.clip = _clips[2];
        _audio.Play();
    }

    public void AttackClick()
    {
        _audio.clip = _clips[3];
        _audio.Play();
    }

    public void RetreatClick()
    {
       _audio.clip = _clips[4];
        _audio.Play();
    }

    public void CarefulClick()
    {
        _audio.clip = _clips[5];
        _audio.Play();
    }
}
