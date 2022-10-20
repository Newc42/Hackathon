using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float enemyHealth = 2f;
    public bool isDead = false;
    public Sprite enemyExplode;
    public GameObject enemy;
    public AudioClip explodeSFX;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Bullet")){
            enemyHealth--;
            if(enemyHealth < 0 && !isDead){
                enemyDie();
            }
        }
    }

    void enemyDie(){
        isDead = true;
        enemy.GetComponent<SpriteRenderer>().sprite = enemyExplode;
        audioSource.PlayOneShot(explodeSFX);
        GameObject.Destroy(this.gameObject, 0.3f);
    }

}
