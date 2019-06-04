using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustDesireTemp : MonoBehaviour
{
    public void UpdateDesireTemp(float i)
    {
        ACData.desiredTemp += i;
    }
}
