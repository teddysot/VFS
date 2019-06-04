using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanPowerScreen : MonoBehaviour
{
    public void GoBack()
    {
        gameObject.SetActive(false);
    }

    public void SetPower(int i)
    {
        switch (i)
        {
            case 1:
                ACData.fanPowerState = "ON";
                break;
            case 2:
                ACData.fanPowerState = "OFF";
                break;
            case 3:
                ACData.fanPowerState = "AUTO";
                break;
        }
    }
}
