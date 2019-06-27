using UnityEngine;

public class SOTester : MonoBehaviour
{
    [SerializeField] private SO _SO1;

    private void Start() 
    {
        var i = _SO1.IntNum;
        _SO1.LoadPlayerPrefs();
    }
}
