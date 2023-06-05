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
        _birdScript.SpaceUpEvent.AddListener(OnSpaceUp);
    }

    private void OnDisable()
    {
        _birdScript.JumpEvent.RemoveListener(OnJump);
        _birdScript.SpaceUpEvent.RemoveListener(OnSpaceUp);
    }

    private void OnSpaceUp()
    {
        _tailAnimator.SetBool("Jumping", false);
    }

    private void OnJump()
    {
        _tailAnimator.SetBool("Jumping", true);
    }
}
