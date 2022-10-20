using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("awdawdaw");
            other.GetComponent<playerHealth>().LoseHp();
        }
        
    }
}
