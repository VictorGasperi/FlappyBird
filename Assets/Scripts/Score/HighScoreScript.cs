using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class HighScoreScript
{

    public static int GetHighScore => PlayerPrefs.GetInt("highscore"); 

    public static bool SetNewHighScore(int score)
    {
        var _highScore = GetHighScore;

        if (score > _highScore)
        {
            PlayerPrefs.SetInt("highscore", score);
            PlayerPrefs.Save();
            return true;
        }

        return false;
    }
}
