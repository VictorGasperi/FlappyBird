using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailAnimationTransition : MonoBehaviour
{
    [SerializeField] private Animator _tailAnimator;
    [SerializeField] private BirdScript _birdScript;

    private void OnEnable()
    {
        _birdScript.JumpEvent.AddListener(OnJump);
    }

    private void OnDisable()
    {
        _birdScript.JumpEvent.RemoveListener(OnJump);
    }

    private void OnJump()
    {
        _tailAnimator.SetTrigger("Jump");
    }
}
