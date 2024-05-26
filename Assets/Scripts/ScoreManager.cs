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
    public int BestScore { get; set; }


    private void Start()
    {
        Instance = this;
        BestScore = DataManager.LoadPlayerData();
        UpdateBestScore();
    }

    public void UpdateScore()
    {
        score++;
        UpdateScoreText(ScoreText, score);
    }

    public void UpdateBestScore()
    {
        BestScore = BestScore < score ? score : BestScore;
        DataManager.SavePlayerData(BestScore);
        UpdateScoreText(BestScoreText, BestScore);
    }

    private void UpdateScoreText(TextMeshProUGUI scoreTextMeshPro, int value) => scoreTextMeshPro.text = value.ToString();
}

