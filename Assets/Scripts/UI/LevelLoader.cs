using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene(transform.name);
    }
}
