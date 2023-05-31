using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    [SerializeField] private PlayerScoreScript _playerScoreScript;
    [SerializeField] private Text _finalScoreText;
    [SerializeField] private GameOver _gameOverScript;

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
        _finalScoreText.text = _playerScoreScript.PlayerScore.ToString();
    }
}
