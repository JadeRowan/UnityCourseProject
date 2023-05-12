﻿using UnityEngine;

namespace Player.PlayerAnimations
{
    public class UnityAnimatorController : AnimationController
    {
        private Animator _animator;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        protected override void PlayAnimation(AnimationType animationType)
        {
            
            _animator.SetInteger(nameof(AnimationType), (int)animationType);
        }
    }
}