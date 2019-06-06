using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : UIScreen
{
    private void OnEnable()
    {
        Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnContinuePressed()
    {
        UIScreenManager.Instance.ShowScreen<GameplayScreen>();
    }

    public void OnQuitPressed()
    {
        UIScreenManager.Instance.ShowScreen<MainMenuScreen>();
        SceneManager.LoadScene("MainMenuScene");
    }
}
