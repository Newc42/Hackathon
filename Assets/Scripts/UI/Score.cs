using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    GameObject gameScore;

    public void ChangeScore()
    {
        score = score + 30;
        Debug.Log(score);
        gameScore.GetComponent<TextMeshProUGUI>().text = "Score: " + score.ToString();
    }


    void Start()
    {
       gameScore = GameObject.FindGameObjectWithTag("Score");
    }
}
