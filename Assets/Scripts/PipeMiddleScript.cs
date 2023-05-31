using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PipeMiddleScript : MonoBehaviour
{ 
    [SerializeField] private PlayerScore _playerScoreScript;

    void Start()
    {
        _playerScoreScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<PlayerScore>();
    }
    
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 3)
        {
            _playerScoreScript.addScore(1);
        }
    }
}
