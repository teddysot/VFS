using UnityEngine;

public class SetRefTransform : MonoBehaviour
{
    [SerializeField] private RefTransform _transform;

    private void OnEnable() 
    {
        _transform.Value = transform;
    }
}
