using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsTest : MonoBehaviour
{
    [SerializeField] private KeyCode _keyToPress;
    [SerializeField] private UnityEvent _OnKeyPressedBart;

    public static event Action<int> DelegateOne;
    
    private void Start()
    {
        DelegateOne += MyFunc1;
        DelegateOne += MyFunc2;
    }

    private void MyFunc1(int i)
    {
        print($"Func1 {i}");
    }

    private void MyFunc2(int i)
    {
        print($"Func2 {i}");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            DelegateOne(1);
        }

        if(Input.GetKeyDown(_keyToPress))
        {
            _OnKeyPressedBart.Invoke();
        }
    }
}
