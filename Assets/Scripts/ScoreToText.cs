using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreToText : MonoBehaviour
{
    private TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        string saveName = BlueBoxLogic.GetSaveName();
        scoreText = GetComponent<TMP_Text>();

        if (saveName == null) return;

        if (PlayerPrefs.HasKey(saveName))
        {
            int score = PlayerPrefs.GetInt(saveName);
            scoreText.text = $"Score: {score}";
        } else 
        {
            scoreText.text = "Score: 0";
        }
    }
}
