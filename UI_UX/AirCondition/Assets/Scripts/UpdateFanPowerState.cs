﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateFanPowerState : MonoBehaviour
{
    private Text _text;
    private void Start() {
        _text = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        _text.text = "Power: " + ACData.fanPowerState;
    }
}
