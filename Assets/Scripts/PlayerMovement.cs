using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    Rigidbody2D playerRb;
    public float playerSpeed = 5f;
    public float vertical;
    public float horizontal;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
        Move();
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        playerRb.velocity = new Vector2(horizontal * playerSpeed, vertical * playerSpeed);
    }

    void Move(){
        
    }
}
