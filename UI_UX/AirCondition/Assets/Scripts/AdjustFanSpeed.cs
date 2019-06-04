using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustFanSpeed : MonoBehaviour
{
    public void UpdateFanSpeed(int i)
    {
        ACData.fanSpeed += i;
    }
}
