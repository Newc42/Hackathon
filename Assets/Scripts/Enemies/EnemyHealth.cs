using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 2f;
    public bool isDead = false;
    public Sprite enemyExplode;
    public AudioClip explodeSFX;
    public AudioSource audioSource;
    public GameObject heart;
    public AudioClip hurtSFX;
    public GameObject enemyManager;
    

    void Start() {
        enemyManager = GameObject.FindGameObjectWithTag("MenuLoader");
    }

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

        if(enemyHealth <= 0 && !isDead){
            EnemyDie();
        }
    }

    void EnemyDie(){
        enemyManager.GetComponent<MenuLoader>().EnemyDestroyed();

        int spawnCoin = Random.Range(0, 10);
        
        if (spawnCoin <= 1){
            SpawnHeart();
        }

        isDead = true;
        GetComponent<SpriteRenderer>().sprite = enemyExplode;
        audioSource.PlayOneShot(explodeSFX);

        if(transform.parent != null){
            Destroy(transform.parent.gameObject, 0.3f);
        }

        GameObject.Destroy(this.gameObject, 0.3f);

    }

    public void SpawnHeart(){
        GameObject heartInstance =  Instantiate(heart, transform.position, transform.rotation);
    }

    void OnDestroy(){
        
    }

}
