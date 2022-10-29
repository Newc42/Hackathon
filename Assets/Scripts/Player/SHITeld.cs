using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHITeld : MonoBehaviour
{
    [SerializeField] float shieldHP = 3f;

    public GameObject shield;



    void Start()
    {
        shield.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
