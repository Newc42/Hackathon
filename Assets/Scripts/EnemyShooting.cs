using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bullet;

    void Start()
    {
        InvokeRepeating("shooting", 1.0f, Random.Range(2f, 5f));
    }

    public void shooting()
    {
        GameObject shotInstance =  Instantiate(bullet, transform.position, transform.rotation);
        shotInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3f);

        GameObject.Destroy(shotInstance, 5f);
    }
}
