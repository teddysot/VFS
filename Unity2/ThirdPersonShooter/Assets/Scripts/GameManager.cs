using UnityEngine;

public class GameManager : SingletonBehaviour<GameManager>
{
    protected override void SingletonAwake() { }

    public Color[] TeamColors;

    private void OnEnable()
    {
        UIScreenManager.Instance.ShowScreen<GameplayScreen>();
    }

    private void OnDisable()
    {
        Instance = null;
    }
}
