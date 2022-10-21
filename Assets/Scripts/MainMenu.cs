using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene("SampleScene");   
    }

    public void OptionScene() {
        SceneManager.LoadScene("OptionScene");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }



    /*
   public void changeScene()
    {
        SceneManager.LoadScene(1);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeScene();
        }
        
    }
    */
}
