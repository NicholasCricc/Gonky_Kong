using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1Scene()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2Scene()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void HighScoreScene()
    {
        SceneManager.LoadScene("HighScore");
    }

}
