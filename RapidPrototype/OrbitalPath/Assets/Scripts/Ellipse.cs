using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse : MonoBehaviour
{
    LineRenderer _lineRenderer;

    [Range(3,36)]
    private int segments;
    private float xAxis;
    private float yAxis;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();    
    }
}
