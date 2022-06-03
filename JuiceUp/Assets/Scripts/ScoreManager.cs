using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private float currentScore;

    private void Start()
    {
        currentScore = 0;
    }

    public void AddScore()
    {
        currentScore++;
    }

    private void Update()
    {
        scoreText.text = "Tomato Killed : " + currentScore.ToString("0");
    }
}
