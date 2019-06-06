using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByName : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    [SerializeField] private bool _loadOnEnable;
    [SerializeField] private bool _additive;

    private void OnEnable()
    {
        if(_loadOnEnable)
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(_sceneName, _additive ? LoadSceneMode.Additive : LoadSceneMode.Single);
    }
}
