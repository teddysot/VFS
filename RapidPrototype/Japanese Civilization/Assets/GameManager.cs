using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int [] Ordering;
    public bool IsCorrect = true;
    public int Rounds = 1;
    public int Points = 0;
    public TextMeshProUGUI RoundsText;
    // Start is called before the first frame update
    void Start()
    {
        Ordering = new int[] {8, 3, 6, 5, 7, 1, 2, 4};
    }

    // Update is called once per frame
    void Update()
    {
        RoundsText.text = "Round: " + Rounds;
        if(IsCorrect == false)
        {
            Debug.Log("You lose");
            
            RoundsText.text = "You Lose!\nScore: " + Points;
        }
    }

    public void ButtonClick(int order)
    {
        if(Ordering[Rounds - 1] == order)
        {
            IsCorrect = true;
            Rounds++;
            Points++;
        }
        else if(Rounds >= 3 && Ordering[Rounds - 1] != order)
        {
            IsCorrect = false;
        }
        else
        {
            Rounds++;
        }
    }
}
