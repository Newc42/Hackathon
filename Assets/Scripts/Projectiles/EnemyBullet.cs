using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public Sprite bulletExplode;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            other.GetComponent<playerHealth>().LoseHp();

            this.GetComponent<SpriteRenderer>().sprite = bulletExplode;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,-0.2f);
            GameObject.Destroy(this.gameObject, 0.2f);
        }
        
    }
}
