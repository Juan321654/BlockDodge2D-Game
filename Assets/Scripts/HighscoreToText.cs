using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighscoreToText : MonoBehaviour
{
    private TMP_Text highscoreText;
    // Start is called before the first frame update
    void Start()
    {
        highscoreText = GetComponent<TMP_Text>();
        string saveName = BlueBoxLogic.GetSaveName();
        string highscoreSaveName = GlobalScoreManager.SaveName;

        if (saveName == null) return;

        if (PlayerPrefs.GetInt(highscoreSaveName) < PlayerPrefs.GetInt(saveName))
        {
            GlobalScoreManager.SaveHighScore(PlayerPrefs.GetInt(saveName));
        }

        int highScore = PlayerPrefs.GetInt(highscoreSaveName);
        highscoreText.text = $"Highscore: {highScore}";
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
