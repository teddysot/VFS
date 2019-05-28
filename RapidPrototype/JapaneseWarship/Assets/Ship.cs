using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Renderer _renderer;
    private Color _startColor;
    private Color _hoverColor = Color.grey;

    public bool IsSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _startColor = _renderer.material.color;
    }

    private void Update()
    {
        if(IsSelected)
        {
            _renderer.material.color = Color.red;
        }

        Destroy(gameObject,2.0f);
    }

    private void OnMouseDown()
    {
        IsSelected = true;
    }
}
