using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreenNewHighScore : MonoBehaviour
{
    [SerializeField] private Text _newHighScoreText;
    [SerializeField] private HighScoreHandler _highScoreHandlerScript;
    private void OnEnable()
    {
        _highScoreHandlerScript.CheckIfNewHighScoreEvent.AddListener(OnNewHighScore);
    }

    private void OnDisable()
    {
        _highScoreHandlerScript.CheckIfNewHighScoreEvent.RemoveListener(OnNewHighScore);
    }

    private void Awake()
    {
        _newHighScoreText.text = "HighScore: " + HighScoreScript.GetHighScore.ToString();
    }

    private void OnNewHighScore()
    {
        _newHighScoreText.text = "New High Score: " + HighScoreScript.GetHighScore.ToString();
    }
    
}
