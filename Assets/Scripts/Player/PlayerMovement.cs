using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    Rigidbody2D playerRb;
    public GameObject player;
    public Sprite spriteRight;
    public Sprite spriteDef;
    public Sprite spriteLeft;
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
        Anim();
    }

    void Move(){
        
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        playerRb.velocity = new Vector2(horizontal * playerSpeed, vertical * playerSpeed);
    }
    
    void Anim(){
        if(horizontal > 0.5f){
            player.GetComponent<SpriteRenderer>().sprite = spriteRight;
        }else if(horizontal < 0.5f && horizontal > 0)
        {
            player.GetComponent<SpriteRenderer>().sprite = spriteDef;
        }

        if(horizontal < -0.5){
            player.GetComponent<SpriteRenderer>().sprite = spriteLeft;
        }else if(horizontal < 0 && horizontal > -0.5f)
        {
            player.GetComponent<SpriteRenderer>().sprite = spriteDef;
        }
    }

}
