using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeScript : MonoBehaviour
{

    private float moveSpeed = 5;
    private float deadZone = -30;
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
        moveSpeed = 0;
    }

    private void Start()
    {
        _gameOverScript = gameObject.transform.parent.
            //todo: achar uma maneira de acessar o script do game over para zerar a velocidade dos pipes quando o player morrer
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
