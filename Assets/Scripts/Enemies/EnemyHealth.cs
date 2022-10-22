using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public float enemyHealth = 2f;
    public bool isDead = false;
    public Sprite enemyExplode;
    public GameObject enemy;
    public AudioClip explodeSFX;
    public AudioSource audioSource;
    public GameObject heart;
    public AudioClip hurtSFX;
    

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Bullet")){
            Destroy(other.gameObject);
            EnemyLoseHp();
        }
    }

    void EnemyLoseHp(){
        enemyHealth--;
        GetComponent<EnemyChangeColor>().ChangeColor();

        audioSource.PlayOneShot(hurtSFX);

        if(enemyHealth < 0 && !isDead){
            EnemyDie();
        }
    }

    void EnemyDie(){
        int spawnCoin = Random.Range(0, 10);

        if(spawnCoin <= 1){
            SpawnHeart();
        }

        isDead = true;
        enemy.GetComponent<SpriteRenderer>().sprite = enemyExplode;
        audioSource.PlayOneShot(explodeSFX);
        GameObject.Destroy(this.gameObject, 0.3f);
    }

    public void SpawnHeart(){
        GameObject heartInstance =  Instantiate(heart, transform.position, transform.rotation);
    }

   
}
