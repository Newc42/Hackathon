using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    [SerializeField] AudioClip levelOneSong;

    public void PlayScene()
    {
        PlayLevelOneMusic();
        SceneManager.LoadScene("SampleScene");   
    }

    public void OptionScene() {
        SceneManager.LoadScene("OptionScene");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    void PlayLevelOneMusic(){
        Debug.Log("play music");
        AudioSource audioSource = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        audioSource.clip = levelOneSong;
        audioSource.Play();
    }

}
