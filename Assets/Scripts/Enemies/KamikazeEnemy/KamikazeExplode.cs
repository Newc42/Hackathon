using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeExplode : MonoBehaviour
{
    [SerializeField]
    Sprite explosionSprite;

    public void Explode(){
        GetComponent<SpriteRenderer>().sprite = explosionSprite;
    }
}
