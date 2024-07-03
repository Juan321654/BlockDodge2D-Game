using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScoreManager : MonoBehaviour
{
    public static GlobalScoreManager Instance;

    public static string SaveName = "HighScore";

    [SerializeField] private int globalScore = 0;
    [SerializeField] private int globalHighScore = 0;

    public static int GlobalScore
    {
        get
        {
            return Instance.globalScore;
        }
        set
        {
            Instance.globalScore = value;
        }
    }

    public static int GlobalHighScore
    {
        get
        {
            return Instance.globalHighScore;
        }
        set
        {
            Instance.globalHighScore = value;
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void AddPointToGlobalScore()
    {
        Instance.globalScore++;
    }

    public static int GetGlobalScore()
    {
        return Instance.globalScore;
    }

    public static void ResetGlobalScore()
    {
        Instance.globalScore = 0;
    }

    public static void SaveHighScore(int value)
    {
        PlayerPrefs.SetInt(SaveName, value);
        PlayerPrefs.Save();
    }

    public static void ResetHighScore()
    {
        PlayerPrefs.SetInt(SaveName, 0);
        PlayerPrefs.Save();
    }

    public static void LoadHighScore()
    {
        if (PlayerPrefs.HasKey(SaveName))
        {
            Instance.globalHighScore = PlayerPrefs.GetInt(SaveName);
        }
    }
}
