using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Win")
        {
            SceneManager.LoadScene("Level 2");
        }
        else if (other.tag == "Win_Screen")
        {

            gameManager.SaveHighScore();


            SceneManager.LoadScene("HighScore");
        }
    }
}
