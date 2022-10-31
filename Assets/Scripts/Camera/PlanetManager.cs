using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetManager : MonoBehaviour
{


    public void PlayLevel()
    {
        SceneManager.LoadScene(transform.parent.name);
    }
}
