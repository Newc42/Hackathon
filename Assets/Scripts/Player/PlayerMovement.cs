using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRb;
    [SerializeField] private float moveSpeed;
    private Vector2 playerMovementDirection;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void GetPlayerInputNormalized(){
        playerMovementDirection.x = Input.GetAxisRaw("Horizontal");
        playerMovementDirection.y = Input.GetAxisRaw("Vertical");

        playerMovementDirection = playerMovementDirection.normalized;

        // Gets player input and makes it normalized.
    }

    private void Update()
    {
        GetPlayerInputNormalized();
    }

    private void FixedUpdate() {
        MovePlayer();
    }

    private void MovePlayer(){
        playerRb.velocity = playerMovementDirection * moveSpeed * Time.fixedDeltaTime;

        // Moves player according to the normalized playerMovementDirection vectror.
    }

    
}
