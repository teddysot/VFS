using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // static reference to our score class
    private static Score _instance;
    public static Score Instance
    {
        get 
        {
            return _instance;
        }

        set
        {
            // prevent assignment if Instance already exists
            if(_instance == null)
            {
                _instance = value;
            }
        }
    }

    // current score and property making it visible to other classes
    [SerializeField] private int _currentScore = 0;
    public int CurrentScore => _currentScore;

    private void Start()
    {
        // assign this instance if Instance == null
        if(Instance != null)
        {
            Debug.LogWarning("Copy of Score singleton created! Very bad!");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    // add to current score
    public void AddScore(int amount)
    {
        _currentScore += amount;
    }
}
