using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelLoader : MonoBehaviour
{

    public int enemies;
    public GameObject enemy;

    
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        
        Debug.Log(enemies);

        if(enemies <= 0){
            SceneManager.LoadScene("Menu");  
            
        }
    }
}
