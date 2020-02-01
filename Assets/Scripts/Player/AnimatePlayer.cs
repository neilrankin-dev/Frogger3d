using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour
{
    private Animator animator;
    PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerManager = GetComponentInParent<PlayerManager>();
        animator.Play("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerManager.isDead)
        {
            PlayerAnimate();
        }
    }

    void PlayerAnimate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0)
        {
            animator.SetFloat("Movement", horizontalInput);
        }
        else if (verticalInput != 0)
        {
            animator.SetFloat("Movement", verticalInput);
        }
        else if (horizontalInput == 0 && verticalInput == 0)
        {
            animator.SetFloat("Movement", 0);
        }
    }

    public void StartAnimate()
    {
        animator.Play("Start");
    }

    public void AnimateDeath()
    {
        animator.Play("Death");
    }
}
