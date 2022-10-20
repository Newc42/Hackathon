using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject player;


    void Update()
    {
        Shoot();
    }

    void Shoot(){
    if (Input.GetKey(KeyCode.Space))
        {
            GameObject shotInstance =  Instantiate(bullet, player.transform.position, player.transform.rotation);
            shotInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 15f);

            GameObject.Destroy(shotInstance, 5f);
            
        }
    }
}
