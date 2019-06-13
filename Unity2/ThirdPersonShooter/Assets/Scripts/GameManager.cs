using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonBehaviour<GameManager>
{
    protected override void SingletonAwake() { }

    public Color[] TeamColors;
    public int[] OutpostCaputured = new int[3];

    private void OnEnable()
    {
        UIScreenManager.Instance.ShowScreen<GameplayScreen>();
    }

    private void Update()
    {
        foreach (var outpost in OutpostCaputured)
        {
            if(outpost == 3)
            {
                UIScreenManager.Instance.ShowScreen<MainMenuScreen>();
                SceneManager.LoadScene("MainMenuScene");
            }
        }
    }

    private void OnDisable()
    {
        Instance = null;
    }
}
