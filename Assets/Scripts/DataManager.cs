using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{

    public static void SavePlayerData(int bestScore)
    {
        PlayerPrefs.SetInt("PlayerBestScore", bestScore);
        PlayerPrefs.Save();
    }

    public static int LoadPlayerData() => PlayerPrefs.GetInt("PlayerBestScore", 0);

}
