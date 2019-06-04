using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolingScreen : MonoBehaviour
{
    [SerializeField] private GameObject _modeScreen;
    [SerializeField] private GameObject _powerScreen;

    public void GoBack()
    {
        gameObject.SetActive(false);
    }

    public void OpenModeScreen()
    {
        _modeScreen.SetActive(true);
    }

    public void OpenPowerScreen()
    {
        _powerScreen.SetActive(true);
    }
}
