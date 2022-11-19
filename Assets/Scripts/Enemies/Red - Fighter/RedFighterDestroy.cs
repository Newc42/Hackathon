using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFighterDestroy : MonoBehaviour
{

    Animator anim;

    void RedFighterExplode(){
        anim = GetComponent<Animator>();
        anim.Play("RedFighterExplode");
    }
}
