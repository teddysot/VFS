using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Health _target;     // The health component to monitor

    private Image _image;       // The image component on healthbar

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        // Target is missing or dead
        if (_target == null)
        {
            // Empty health bar
            _image.fillAmount = 0.0f;
        }
        else
        {
            // Set fill to current health percentage
            _image.fillAmount = _target.HealthPercentage;
        }
    }
}
