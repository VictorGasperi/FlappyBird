using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _myRigidBody;

    public Rigidbody2D MyRigidBody
    {
        get => _myRigidBody;
        set => _myRigidBody = value;
    }
    [SerializeField] private float flapStrength;
    [FormerlySerializedAs("_playerScoreScript")] [SerializeField] private PlayerScoreScript playerScoreScriptScript;
    [SerializeField] private GameOver _gameOverScript;
    [SerializeField] private CircleCollider2D _cicleCollider;
    private bool birdIsAlive = true;

    public UnityEvent JumpEvent;
    public UnityEvent SpaceUpEvent;

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
        birdIsAlive = false;
        _cicleCollider.enabled = false;
    }
    
    void Start()
    {
        playerScoreScriptScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<PlayerScoreScript>();
    }
    
    public void Jump(InputAction.CallbackContext context)
    {
        if (birdIsAlive)
        {
            MyRigidBody.velocity = Vector2.up * flapStrength;
            JumpEvent.Invoke();
        }
    }
}
