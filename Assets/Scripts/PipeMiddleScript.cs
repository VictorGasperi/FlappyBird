using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PipeMiddleScript : MonoBehaviour
{ 
    [FormerlySerializedAs("_playerScoreScript")] [SerializeField] private PlayerScoreScript playerScoreScriptScript;

    void Start()
    {
        playerScoreScriptScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<PlayerScoreScript>();
    }
    
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 3)
        {
            playerScoreScriptScript.addScore(1);
        }
    }
}
