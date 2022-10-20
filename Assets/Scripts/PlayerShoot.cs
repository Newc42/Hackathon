using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject player;
    public AudioClip shootSFX;
    public AudioSource audioSource;

    void Update()
    {

        if(Input.GetKey(KeyCode.Space)){
            Shoot();
        }
    }

    void Shoot(){
    if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(shootSFX);

            GameObject shotInstance =  Instantiate(bullet, player.transform.position, player.transform.rotation);
            shotInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 15f);

            GameObject.Destroy(shotInstance, 5f);
            
        }
        
    }

}
