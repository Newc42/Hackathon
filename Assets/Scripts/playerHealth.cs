using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float playerHp = 10;
    public AudioClip heartPickup;
    public AudioSource audioSource;
    public AudioClip hurt;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Heart")){
            playerHp += 1;
            GameObject.Destroy(other.gameObject);
            audioSource.PlayOneShot(heartPickup);
        }
    }

    public void LoseHp(){
        playerHp -= 1;
        Debug.Log(playerHp);
        audioSource.PlayOneShot(hurt);
    }

}
