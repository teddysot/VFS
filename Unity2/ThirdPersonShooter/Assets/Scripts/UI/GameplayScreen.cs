using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayScreen : UIScreen
{
    [SerializeField] private KeyCode _keyToPause = KeyCode.Backspace;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        if(Input.GetKeyDown(_keyToPause))
        {
            UIScreenManager.Instance.ShowScreen<PauseScreen>();
        }
    }
}
