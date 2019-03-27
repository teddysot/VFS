using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Static reference to our score class
    private static Score _instance;
    public static Score Instance
    {
        get
        {
            return _instance;
        }

        set
        {
            // Prevent assignment if Instance already exists
            if(_instance == null)
            {
                _instance = value;
            }
        }
    }

    // Current score and property making it visible to other classes
    [SerializeField]
    private int _currentScore = 0;
    public int CurrentScore => _currentScore;

    private void Start()
    {
        // Assign this instance if Instace == null
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

    // Add to current score
    public void AddScore(int amount)
    {
        _currentScore += amount;
    }
}
