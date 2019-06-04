using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreen : MonoBehaviour
{
    [SerializeField] private GameObject _coolingScreen;

    public void OpenCoolingScreen()
    {
        _coolingScreen.SetActive(true);
    }
}
