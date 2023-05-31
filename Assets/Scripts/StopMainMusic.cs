using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMainMusic : MonoBehaviour
{
    [SerializeField] private GameOver _gameOverScript;
    [SerializeField] private GameObject _mainCamera;

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
        AudioSource _mainCameraAudio = _mainCamera.GetComponent<AudioSource>();
        _mainCameraAudio.Stop();    
    }
}
