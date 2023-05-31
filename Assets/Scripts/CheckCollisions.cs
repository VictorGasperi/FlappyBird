using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckCollisions : MonoBehaviour
{
    public UnityEvent CollisionEvent;
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Pipe"))
        {
            CollisionEvent.Invoke();     
        }
       
    }
}
