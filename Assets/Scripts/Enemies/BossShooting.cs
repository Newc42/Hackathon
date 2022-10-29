using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{

    public GameObject bullet;




    void Start()
    {
        InvokeRepeating("shooting", Random.Range(2f, 5f), Random.Range(2f, 5f));
    }

    public void shooting()
    {
        GameObject shotInstance =  Instantiate(bullet, transform.position, transform.rotation);
        shotInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -10f);

        GameObject.Destroy(shotInstance, 1.5f);
    }
}