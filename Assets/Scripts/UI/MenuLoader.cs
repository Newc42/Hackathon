using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    int enemies;
    [SerializeField] AudioClip menuSong;

    public void ChangeScene(){
        enemies = GameObject.FindGameObjectsWithTag("Enemy").Length-1;
        Debug.Log(enemies);
        if(enemies <= 0){
            SceneManager.LoadScene("Menu");
        }
    }
}
