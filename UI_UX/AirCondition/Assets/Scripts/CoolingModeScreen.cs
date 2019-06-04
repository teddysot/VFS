using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolingModeScreen : MonoBehaviour
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
                ACData.state = "COOL";
                break;
            case 2:
                ACData.state = "HEAT";
                break;
            case 3:
                ACData.state = "AUTO";
                break;
        }
    }
}
