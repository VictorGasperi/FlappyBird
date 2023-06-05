using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeScript : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 15;
    private float deadZone = -30;
    [SerializeField] private GameOver _gameOverScript;

    private void Awake()
    {
        _gameOverScript = GameObject.FindWithTag("GameOver").GetComponent<GameOver>();
    }

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
        moveSpeed = 0;
    }

    void FixedUpdate()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
