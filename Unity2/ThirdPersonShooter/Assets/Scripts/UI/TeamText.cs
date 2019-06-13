using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TeamText : MonoBehaviour
{
    [SerializeField] private int _teamNumber;

    private Text _teamText;

    private Outpost _outpost;

    private void Awake()
    {
        _teamText = GetComponent<Text>();    
    }

    private void Update()
    {
        int capturedOutpost = GameManager.Instance.OutpostCaputured[_teamNumber - 1];
        _teamText.text = capturedOutpost.ToString();
    }

    private void OnEnable()
    {
        _teamText.color = GameManager.Instance.TeamColors[_teamNumber - 1];
    }
}
