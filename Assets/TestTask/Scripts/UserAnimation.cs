using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

public class UserAnimation : MonoBehaviour
{
    private string[] _attackIds = new string[] {"TOP", "MID", "BOT"};
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void StartAnimation(string animationId)
    {
        _animator.Play(animationId);
    }
}
