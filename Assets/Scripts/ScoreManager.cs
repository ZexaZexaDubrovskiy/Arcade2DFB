using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; set; }
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private TextMeshProUGUI BestScoreText;
    public int score { get; set; }
    //TODO сделать статик или записывать в файл
    public static int BestScore { get; set; }

    private void Start()
    {
        Instance = this;
    }

    public void SetScore(int Value = 1)
    {
        this.score += Value;
        ScoreText.text = "Score: " + this.score.ToString();
        SetBestScore();
    }

    private void SetBestScore()
    {
        if (score > BestScore)
        {
            BestScore = score;
        }
        BestScoreText.text = "Best score: " + BestScore.ToString();

    }
    
}
