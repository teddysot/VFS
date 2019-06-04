using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanScreen : MonoBehaviour
{
    [SerializeField] private GameObject _powerScreen;

    public void GoBack()
    {
        gameObject.SetActive(false);
    }

    public void OpenPowerScreen()
    {
        _powerScreen.SetActive(true);
    }
}
