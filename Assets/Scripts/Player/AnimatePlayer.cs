using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
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

        //animator.SetFloat("Movement", Input.GetAxis("Vertical"));
    }
}
