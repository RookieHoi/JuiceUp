using System.Collections;
using System.Collections.Generic;
using EZCameraShake;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private float m_magnitude;
    [SerializeField] private float m_roughness;
    [SerializeField] private float m_fadeIn;
    [SerializeField] private float m_fadeOut;
    
    [SerializeField] private Text scoreText;
    private float currentScore;

    private void Start()
    {
        currentScore = 0;
    }

    public void AddScore()
    {
        CameraShaker.Instance.ShakeOnce(m_magnitude, m_roughness, m_fadeIn, m_fadeOut);
        currentScore += 10;
    }

    private void Update()
    {
        scoreText.text = "Score : " + currentScore.ToString("0");
    }
}
