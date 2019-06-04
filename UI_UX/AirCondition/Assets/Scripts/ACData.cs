using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACData : MonoBehaviour
{
    // Cooling/Heat
    public static float currentTemp = 20.0f;
    public static float desiredTemp = 20.0f;
    public static string state = "COOL";
    public static string powerState = "OFF";

    // Fans
    public static int fanSpeed = 0;
    public static string fanPowerState = "OFF";

    private float _duration = 5.0f;
    private bool _isIncreasing = false;
    private bool _isDecreasing = false;

    private float _currentTime = 0.0f;

    private void Update()
    {
        if(fanSpeed < 0)
        {
            fanSpeed = 0;
        }
        else if(fanSpeed > 4)
        {
            fanSpeed = 4;
        }
        
        if (currentTemp < desiredTemp)
        {
            _currentTime = 0.0f;
            _isIncreasing = true;

            if (_isIncreasing)
            {
                if (_currentTime <= _duration)
                {
                    _currentTime += Time.deltaTime;
                    currentTemp = Mathf.Lerp(currentTemp, currentTemp + 1.0f, _currentTime / _duration);
                }
                else
                {
                    _isIncreasing = false;
                    _isDecreasing = false;
                }
            }
        }
        else if (currentTemp > desiredTemp)
        {
            _currentTime = 0.0f;
            _isDecreasing = true;

            if (_isDecreasing)
            {
                if (_currentTime <= _duration)
                {
                    _currentTime += Time.deltaTime;
                    currentTemp = Mathf.Lerp(currentTemp, currentTemp - 1.0f, _currentTime / _duration);
                }
                else
                {
                    _isIncreasing = false;
                    _isDecreasing = false;
                }
            }
        }
        else
        {
            _isDecreasing = false;
            _isIncreasing = false;
        }
    }
}
