using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScriptMainMenu : MonoBehaviour
{
    [SerializeField] private Text _highScoreText;

    private void Awake()
    {
        _highScoreText.text = "High Score: " + HighScoreScript.GetHighScore.ToString();
    }
}
