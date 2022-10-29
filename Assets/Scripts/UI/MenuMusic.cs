using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour
{
    

    private void Awake()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Music");
        if (musicObj.Length > 1)
        {
            Debug.Log("zniszczono: " + this.gameObject);
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
