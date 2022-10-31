using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeEnemyMovement : MonoBehaviour
{
    public Transform player;

    float agroRange = 5;

    Rigidbody2D enemyRb;
    float moveSpeedAfter = 50f;
    float moveSpeedBefore = 2f;
    bool canMove = true;

    private Vector2 movement;

    private void Start() {
        enemyRb = GetComponent<Rigidbody2D>();
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

        if(distToPlayer < 1.5f){
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
        GameObject.Destroy(this.gameObject);
    }
}
