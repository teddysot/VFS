using UnityEngine;

[CreateAssetMenu]
public class SO : ScriptableObject
{
    public int IntNum;

    [SerializeField] private float _floatNum;

    [SerializeField] private Transform _playerTransform;

    [SerializeField] private string _playerPrefsName = "SO";

    [ContextMenu("Save")]
    public void SaveToPlayerPrefs()
    {
        PlayerPrefs.SetFloat($"{_playerPrefsName}_Float", _floatNum);
        PlayerPrefs.SetInt($"{_playerPrefsName}_Int", IntNum);
        PlayerPrefs.SetString($"{_playerPrefsName}_String", "Hello PG15");
        Debug.Log("Saved");
    }

    [ContextMenu("Load")]
    public void LoadPlayerPrefs()
    {
        var f = PlayerPrefs.GetFloat($"{_playerPrefsName}_Float");
        var i = PlayerPrefs.GetInt($"{_playerPrefsName}_Int");
        var s = PlayerPrefs.GetString($"{_playerPrefsName}_String");
        Debug.Log($"{f} - {i} - {s}");
    }
}
