using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paning : MonoBehaviour
{

    Vector3 touchStart;
    public GameObject spaceBackground;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0)){
            Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += direction;
            spaceBackground.transform.position += new Vector3(direction.x * 0.9f, direction.y * 0.9f, direction.z);
        }
        
    }
}
