using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeEnemyMovement : MonoBehaviour
{
    Transform player;
    float agroRange = 5;
    Rigidbody2D enemyRb;
    float moveSpeedAfter = 50f;
    float moveSpeedBefore = 2f;
    bool canMove = true;
    Animator anim;
    AudioSource source;
    public AudioClip kamikazeExplodeSFX;
    bool stopPlayingThisFuckingSound = false;

    public float explosionDamage = 2;
    bool thrustEnabled = false;

    private Vector2 movement;

    private void Start() {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Move(){
        transform.position += new Vector3(0, -moveSpeedBefore * Time.deltaTime, 0);
    }

    private void Update() {

        if(canMove){
            Move();
        }

        Vector3 direction = player.transform.position - transform.position;

        float distToPlayer = Vector2.Distance(transform.position, player.transform.position);

        if(distToPlayer < agroRange){
            canMove = false;
            ChasePlayer(direction);   
        }

        if(distToPlayer < agroRange && !thrustEnabled){
            thrustEnabled = true;
            GameObject.FindGameObjectWithTag("sss").GetComponent<SpriteRenderer>().enabled = enabled;
            GameObject.FindGameObjectWithTag("ssss").GetComponent<Transform>().rotation = Quaternion.Euler(0,0,90);
        }

        if(distToPlayer < 0.8f && !stopPlayingThisFuckingSound){
            stopPlayingThisFuckingSound = true;
            EnemyExplode();
        }

    }

    void ChasePlayer(Vector3 direction){

        RotateEnemy(direction);

        direction.Normalize();
        movement = direction;

        enemyRb.MovePosition(transform.position + (direction * moveSpeedAfter * Time.deltaTime));
    }

    void RotateEnemy(Vector3 direction){
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        enemyRb.rotation = angle;
    }

    void EnemyExplode(){  
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        source.PlayOneShot(kamikazeExplodeSFX);
        anim.Play("KamikazeExplode");

        GameObject.FindGameObjectWithTag("Player").GetComponent<playerHealth>().LoseHp(explosionDamage);

        GameObject.Destroy(this.gameObject, 0.5f);
    }
}
