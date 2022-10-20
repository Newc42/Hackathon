using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float accelerationTime = 2f;
    public Rigidbody2D rb;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;
    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
    {
        movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        timeLeft += accelerationTime;
    }
    }
    
    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }
}
