using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SaveHighScore : MonoBehaviour
{
    [SerializeField] private PlayerScoreScript _playerScore;
    [SerializeField] private GameOver _gameOverScript;
    public UnityEvent HighScoreChangedEvent;
    public int HighScore { get; private set; }

    private void OnEnable()
    {
        _gameOverScript.GameOverEvent.AddListener(SetNewHighScore);
    }

    private void OnDisable()
    {
        _gameOverScript.GameOverEvent.RemoveListener(SetNewHighScore);
    }

    private void SetNewHighScore()
    {
        HighScore = PlayerPrefs.GetInt("highscore");
        if (_playerScore.PlayerScore <= HighScore) return;
        PlayerPrefs.SetInt("highscore", _playerScore.PlayerScore);
        PlayerPrefs.Save();
        Debug.Log(HighScore);
        HighScoreChangedEvent.Invoke();
    }
    [ContextMenu("ResetHighScore")]
    public void ResetHighScore()
    {
        HighScore = 0;
        PlayerPrefs.SetInt("highscore", HighScore);
        PlayerPrefs.Save();
    }
}
