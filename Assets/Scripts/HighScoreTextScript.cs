using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTextScript : MonoBehaviour
{
    //[SerializeField] private SaveHighScore _saveHighScoreScript;
    [SerializeField] private Text _highScoreText;

    private void Start()
    {
        _highScoreText.text = HighScoreScript.GetHighScore.ToString();
    }
}
