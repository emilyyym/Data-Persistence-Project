using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class HighScore : MonoBehaviour
{
    
    private int Bestscore;
    public static HighScore instance { get; private set; }
    public Text HighScoreText;

    
    private void OnAwake()
    {
       
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void SetHighscore(int score)
    {
        Bestscore = score;
        UpdateScoreUI();

        string json = JsonUtility.ToJson(score);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public int GetBestScore()
    {
        return Bestscore;
    }
    public void UpdateScoreUI()
    {
        if (HighScoreText != null)
        {
            HighScoreText.text = $"Highscore: {Bestscore}";
        }
        else
        {
            Debug.LogWarning("HighscoreText reference is missing in HighScore.cs!");
        }
    }
}
    
