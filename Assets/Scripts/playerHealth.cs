using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float playerHp;
    public AudioClip heartPickup;
    public AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Heart")){
            playerHp += 1;
            GameObject.Destroy(other.gameObject);
        }
    }
}
