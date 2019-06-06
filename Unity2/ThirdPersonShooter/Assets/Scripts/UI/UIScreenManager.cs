using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScreenManager : SingletonBehaviour<UIScreenManager>
{
    private UIScreen _currentScreen;
    private Dictionary<Type, UIScreen> _screens;
    protected override void SingletonAwake()
    {
        _screens = new Dictionary<Type, UIScreen>();

        foreach( var screen in GetComponentsInChildren<UIScreen>(true))
        {
            print($"Screen {screen.name} Added");
            screen.gameObject.SetActive(false);
            _screens.Add(screen.GetType(), screen);
        }

        ShowScreen<MainMenuScreen>();
    }

    public void ShowScreen<T>() where T : UIScreen
    {
        if(_currentScreen != null)
        {
            _currentScreen.gameObject.SetActive(false);
        }

        var screenType = typeof(T);
        if(_screens.ContainsKey(screenType) == false)
        {
            return;
        }

        _currentScreen = _screens[screenType];
        _currentScreen.gameObject.SetActive(true);
    }
}
