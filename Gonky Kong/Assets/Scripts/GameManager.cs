using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text playerScoreText;

    [SerializeField] Text livesText;

    [SerializeField] GameObject playerPrefab;




    // Start is called before the first frame update
    void Start()
    {
        GameData.Score = 0;
        GameData.Lives = 3;
        playerScoreText.text = "Score: " + GameData.Score.ToString();
        livesText.text = "Lives: " + GameData.Lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDie()
    {
        GameData.Lives--;
        livesText.text = "Lives: " + GameData.Lives.ToString();
        if (GameData.Lives > 0) Instantiate(playerPrefab, new Vector3(-5f, 0f, 0f), Quaternion.identity);
        else SceneManager.LoadScene("Lose_Scene");
    }
}
