using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.Build.Content;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public void addScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score >= 100)
        {
            SceneManager.LoadScene("Menu",LoadSceneMode.Single);
        }
        
    }
    private void Start()
    {
             // FindObjectOfType<AudioManager>().Play("Ambient0");
        
    }
}
