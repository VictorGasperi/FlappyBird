using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTextScript : MonoBehaviour
{
    [SerializeField] private SaveHighScore _saveHighScoreScript;
    [SerializeField] private Text _highScoreText;

    private void OnEnable()
    {
        _saveHighScoreScript.HighScoreChangedEvent.AddListener(OnHighScoreChanged);
    }

    private void OnDisable()
    {
        _saveHighScoreScript.HighScoreChangedEvent.AddListener(OnHighScoreChanged);
    }

    private void OnHighScoreChanged()
    {
        _highScoreText.text = _saveHighScoreScript.HighScore.ToString();
    }
}
