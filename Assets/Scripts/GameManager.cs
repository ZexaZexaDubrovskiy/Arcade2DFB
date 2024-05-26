using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loseWindow;
    public static GameManager instance;

    private int target = 60;

    void Awake()
    {
        Application.targetFrameRate = target;
    }

    void Update()
    {
        if (Application.targetFrameRate != target)
            Application.targetFrameRate = target;
    }


    private void Start()
    {
        instance = this;
    }


    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Lose()
    {
        loseWindow.SetActive(true);
        Time.timeScale = 0;
    }

    public void LoadScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }



    void SaveGameData()
    {
        PlayerData playerData = new PlayerData();
        playerData.BestScore = ScoreManager.BestScore;
        DataManager.SavePlayerData(playerData);
    }

    void LoadGameData()
    {
        PlayerData loadedData = DataManager.LoadPlayerData();
        Debug.Log("Loaded player score: " + loadedData.BestScore);
    }


}
