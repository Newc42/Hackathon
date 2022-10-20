using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelLoader : MonoBehaviour
{

    public int enemies;
    public GameObject enemy;

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);

        for (int i = 0; i < enemies+1; i++)
        {
            Debug.Log("LubiePlacki");
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }

    

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        
        Debug.Log(enemies);

        if(enemies <= 0){
            enemies+=1;
            SceneManager.LoadScene("SampleScene");  
        }
    }
}
