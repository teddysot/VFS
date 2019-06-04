using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolingPowerScreen : MonoBehaviour
{
    public void GoBack()
    {
        gameObject.SetActive(false);
    }

    public void SetMode(int i)
    {
        switch (i)
        {
            case 1:
                ACData.powerState = "ON";
                break;
            case 2:
                ACData.powerState = "OFF";
                break;
            case 3:
                ACData.powerState = "AUTO";
                break;
        }
    }
}
