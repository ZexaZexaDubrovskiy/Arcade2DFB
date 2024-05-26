using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{

    public static void SavePlayerData(PlayerData playerData)
    {
        PlayerPrefs.SetInt("Score", playerData.score);
        PlayerPrefs.Save();
    }

    public static PlayerData LoadPlayerData()
    {
        PlayerData loadedData = new PlayerData();
        loadedData.score = PlayerPrefs.GetInt("Score", 0);
        return loadedData;
    }



}
