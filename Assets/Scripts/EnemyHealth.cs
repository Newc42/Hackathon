using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float enemyHealth = 2f;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Bullet")){
            enemyHealth--;
            if(enemyHealth < 0){
                enemyDie();
            }
        }
    }

    void enemyDie(){
        GameObject.Destroy(this.gameObject);
    }

}
