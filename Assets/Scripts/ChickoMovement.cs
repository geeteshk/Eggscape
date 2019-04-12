using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickoMovement : MonoBehaviour
{
    // Movement speed
    public float speed;

    // RigidBody2D of Chicko object
    private Rigidbody2D rigidBody;

    // Difference the player moves by
    private Vector3 movementDelta;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        movementDelta = Vector3.zero;
        movementDelta.x = Input.GetAxisRaw("Horizontal");
        movementDelta.y = Input.GetAxisRaw("Vertical");

        if (movementDelta != Vector3.zero)
        {
            MoveChicko();
        }
    }
    
    void MoveChicko()
    {
        rigidBody.MovePosition(transform.position + movementDelta * speed * Time.deltaTime);
    }
}
