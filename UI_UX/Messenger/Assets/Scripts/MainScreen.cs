using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreen : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private GameObject _CreateChannelScreen;
    [SerializeField] private GameObject _JoinChannelScreen;

    public void CreateChannel()
    {
        UpdateNickname();
        Instantiate(_CreateChannelScreen, transform.position, Quaternion.identity);
    }

    public void JoinChannel()
    {
        UpdateNickname();
        Instantiate(_JoinChannelScreen, transform.position, Quaternion.identity);
    }

    private void UpdateNickname()
    {
        AppManager.nickname = _text.text;
    }
}
