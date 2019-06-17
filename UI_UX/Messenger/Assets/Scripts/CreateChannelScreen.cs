using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateChannelScreen : MonoBehaviour
{
    [SerializeField] private GameObject _channelScreen;
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _passwordText;

    public void CreateChannel()
    {
        UpdateChannel();
        Instantiate(_channelScreen, transform.position, Quaternion.identity);
    }

    public void Cancel()
    {
        Destroy(gameObject);
    }

    private void UpdateChannel()
    {
        AppManager.channel = _nameText.text;
        AppManager.password = _passwordText.text;
    }
}
