using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreen : MonoBehaviour
{
    [SerializeField] private GameObject _coolingScreen;
    [SerializeField] private GameObject _fanScreen;

    public void OpenCoolingScreen()
    {
        _coolingScreen.SetActive(true);
    }

    public void OpenFanScreen()
    {
        _fanScreen.SetActive(true);
    }
}
