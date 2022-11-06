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
    [SerializeField] GameObject myCamera;

    public Slider HPSlider;

    private void Start() {
        HPSlider.maxValue = playerHp;
        HPSlider.value = HPSlider.maxValue - playerHp;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Heart")){
            
            playerHp += 1;
            GameObject.Destroy(other.gameObject);
            audioSource.PlayOneShot(heartPickup);
            
            HPSlider.value = HPSlider.maxValue - playerHp;
            
        }


    }

    public void LoseHp(float damage){
        playerHp -= damage;
        audioSource.PlayOneShot(hurt);
        HPSlider.value = HPSlider.maxValue - playerHp;

        GetComponent<PlayerChangeColor>().ChangeColor();
        myCamera.GetComponent<CameraShake>().Play();

        if(playerHp<=0){
            PlayerDie();
        }
    }

    public void PlayerDie(){
        SceneManager.LoadScene("Menu");  
        GameObject.Destroy(this.gameObject);
    }
}
