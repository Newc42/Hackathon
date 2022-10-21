using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public float playerHp = 10;
    public AudioClip heartPickup;
    public AudioSource audioSource;
    public AudioClip hurt;

    public Slider HPSlider;

    private void Start() {
        HPSlider.maxValue = playerHp;
        HPSlider.value = playerHp;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Heart")){
            
            playerHp += 1;
            GameObject.Destroy(other.gameObject);
            audioSource.PlayOneShot(heartPickup);
            
            HPSlider.value = playerHp;
            
        }
    }

    public void LoseHp(){
        playerHp -= 1;
        Debug.Log(playerHp);
        audioSource.PlayOneShot(hurt);
        HPSlider.value = playerHp;
        if(playerHp<=0){
            playerDie();
        }
    }

    public void playerDie(){
        SceneManager.LoadScene("Menu");  
        GameObject.Destroy(this.gameObject);
    }

}
