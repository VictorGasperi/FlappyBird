using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScoreScript : MonoBehaviour
{
    public int PlayerScore { get; private set; }
    [SerializeField] private Text scoreText;

    public UnityEvent AddScoreEvent;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        PlayerScore += scoreToAdd;
        scoreText.text = PlayerScore.ToString();
        AddScoreEvent.Invoke();
    }
}
