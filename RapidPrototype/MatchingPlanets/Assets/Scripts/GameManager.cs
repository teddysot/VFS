using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Sprite[] _images;
    [SerializeField] private Button[] options;
    [SerializeField] private Image _showImage;
    [SerializeField] private Text _scoreText;
    [SerializeField] private string[] name;

    private int[] randomImage = { 0, 0, 0 };

    private int _score = 0;

    private void Awake()
    {
        for (int i = 0; i < _images.Length; i++)
        {
            name[i] = _images[i].name;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
        RandomImage();
    }

    private void UpdateScore()
    {
        _scoreText.text = "Score: " + _score.ToString();
    }

    private void RandomImage()
    {
        for (int i = 0; i < options.Length; i++)
        {
            int a = Random.Range(0, _images.Length - 1);
            randomImage[i] = a;
            options[i].GetComponentInChildren<Text>().text = name[a];
        }

        int b = Random.Range(0, 2);
        _showImage.sprite = _images[randomImage[b]];
    }

    public void CheckAnswer(int i)
    {
        if (_showImage.sprite.name == options[i].GetComponentInChildren<Text>().text)
        {
            _score++;
            UpdateScore();
            RandomImage();
        }
        else
        {
            _score--;
            UpdateScore();
        }
    }
}
