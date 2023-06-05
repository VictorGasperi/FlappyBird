using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class HighScoreHandler : MonoBehaviour
{
    private int _highScore;

    [SerializeField] private PlayerScoreScript _playerScoreScript;
    [SerializeField] private GameOver _gameOverScript;
    public UnityEvent CheckIfNewHighScoreEvent;

    private void OnEnable()
    {
        _gameOverScript.GameOverEvent.AddListener(OnGameOver);
    }

    private void OnDisable()
    {
        _gameOverScript.GameOverEvent.RemoveListener(OnGameOver);
    }

    private void OnGameOver()
    {
        if (HighScoreScript.SetNewHighScore(_playerScoreScript.PlayerScore))
        {
            CheckIfNewHighScoreEvent.Invoke();
        }
    }

    private void Awake()
    {
        _highScore = PlayerPrefs.GetInt("highscore");
    }

    [ContextMenu("ResetHighScore")]
    public void ResetHighScore()
    {
        _highScore = 0;
        PlayerPrefs.SetInt("highscore", _highScore);
        PlayerPrefs.Save();
    }
}
