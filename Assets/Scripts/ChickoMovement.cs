using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickoMovement : MonoBehaviour
{
    // Movement speed
    public float speed;

    // RigidBody2D of Chicko object
    private Rigidbody2D rigidBody;

    // Animator of Chicko object
    private Animator animator;

    // Difference the player moves by
    private Vector3 movementDelta;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        // Get raw input from axes so that movement is more snappy
        movementDelta = Vector3.zero;
        movementDelta.x = Input.GetAxisRaw("Horizontal");
        movementDelta.y = Input.GetAxisRaw("Vertical");

        AnimateAndMoveChicko();
    }

    void AnimateAndMoveChicko()
    {
        if (movementDelta != Vector3.zero)
        {
            // Perform movement
            MoveChicko();

            // Update animator values
            animator.SetFloat("moveX", movementDelta.x);
            animator.SetFloat("moveY", movementDelta.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }
    
    void MoveChicko()
    {
        rigidBody.MovePosition(transform.position + movementDelta * speed * Time.deltaTime);
    }
}
