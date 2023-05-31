using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private CheckCollisions _checkCollisionsScript;
    [SerializeField] private GameObject _mainCamera;
    
    public UnityEvent GameOverEvent;

    private void OnEnable()
    {
        _checkCollisionsScript.CollisionEvent.AddListener(OnCollision);
        
    }

    private void OnDisable()
    {
        _checkCollisionsScript.CollisionEvent.RemoveListener(OnCollision);
    }

    private void OnCollision()
    {
        gameOverScreen.SetActive(true);
        GameOverEvent.Invoke();
    }
}
