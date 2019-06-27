using System;
using UnityEngine;

[CreateAssetMenu(menuName = "RefVariable/Transform", fileName = "Transform_")]
public class RefTransform : ScriptableObject
{
    public Transform Value;
}

[CreateAssetMenu(menuName = "RefVariable/Float", fileName = "Float_")]
public class RefFloat : ScriptableObject
{
    private float _value;

    public float Value
    {
        get => _value;
        set
        {
            if(Value != _value)
            {
                _value = Value;
                OnValueChanged(_value);
            }
        }
    }

    public event Action<float> OnValueChanged = delegate {};
}
