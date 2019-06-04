using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACData : MonoBehaviour
{
    public static float currentTemp = 20.0f;
    public static float desiredTemp = 20.0f;
    public static string state = "COOL";
    public static string powerState = "OFF";

    private float _duration = 5.0f;
    private bool _isIncreasing = false;
    private bool _isDecreasing = false;

    private float _currentTime = 0.0f;

    private void Update()
    {
        if (currentTemp < desiredTemp)
        {
            _currentTime = 0.0f;
            _isIncreasing = true;
        }
        else if (currentTemp > desiredTemp)
        {
            _currentTime = 0.0f;
            _isDecreasing = true;
        }
        else
        {
            _isDecreasing = false;
            _isIncreasing = false;
        }

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
            }
        }

        if (_isDecreasing)
        {
            if (_currentTime <= _duration)
            {
                _currentTime += Time.deltaTime;
                currentTemp = Mathf.Lerp(currentTemp, currentTemp - 1.0f, _currentTime / _duration);
            }
            else
            {
                _isDecreasing = false;
            }
        }
    }
}
