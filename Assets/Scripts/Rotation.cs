using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private BirdScript _birdScript;
    //[SerializeField] private Vector3 _axisRotate;
    [SerializeField] private float _rotationSpeed;
    //[SerializeField] private Quaternion _originalAngle;
    //private float time = 0.5f;
    
    
    // private void OnEnable()
    // {
    //     _birdScript.JumpEvent.AddListener(OnJump);
    // }
    //
    // private void OnDisable()
    // {
    //     _birdScript.JumpEvent.RemoveListener(OnJump);
    // }
    
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,_birdScript.MyRigidBody.velocity.y * _rotationSpeed);
    }

    
}
