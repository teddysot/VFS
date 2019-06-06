using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TeamText : MonoBehaviour
{
    [SerializeField] private int _teamNumber;
    private Text _teamText;

    private void Awake()
    {
        _teamText = GetComponent<Text>();    
    }

    private void OnEnable()
    {
        _teamText.color = GameManager.Instance.TeamColors[_teamNumber];
    }
}
