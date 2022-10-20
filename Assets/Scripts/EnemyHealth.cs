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

    public Slider HPSlider;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Bullet")){
            enemyHealth--;
            
            if(enemyHealth < 0 && !isDead){
                enemyDie();
            }
        }
    }

    void enemyDie(){
        int spawnCoin = Random.Range(0, 10);

        if(spawnCoin <= 1){
            spawn();
        }

        isDead = true;
        enemy.GetComponent<SpriteRenderer>().sprite = enemyExplode;
        audioSource.PlayOneShot(explodeSFX);
        GameObject.Destroy(this.gameObject, 0.3f);
    }

    public void spawn(){
        GameObject heartInstance =  Instantiate(heart, transform.position, transform.rotation);
        heartInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -0.05f);
    }

   

}
