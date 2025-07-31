using System;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerMovement playerMovement;

    private void Update()
    {
        animator.SetBool("isWalking", playerMovement.isWalking);
        animator.SetBool("isRunning", playerMovement.isRunning);
        animator.SetBool("isJumping", !playerMovement.canJump);
    }
}