using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    private Text playerScoreText;

    private Slider livesSlider;

    private GameObject playerPrefab;

    private Text PlayerHighScore;

    SaveManager MySaveManager;

    public static GameManager _instance;


    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

        Highscore();
        Score();
        SliderLives();
        PlayerPrefab();

        GameData.Lives = 4;
        MySaveManager = GetComponent<SaveManager>();

        MySaveManager.LoadData();

        
        

    }

    // Update is called once per frame
    void Update()
    {
        playerPrefab = GameObject.FindGameObjectWithTag("Player");

        

        try
        {
            GameData.playerpos = playerPrefab.transform.position;
        }
        catch (NullReferenceException)
        {
            Debug.Log("Missing Player");
        }

        SaveHighScore();

        MySaveManager.SaveMyData();

    }

    public void PlayerDie()
    {
        GameData.Lives--;
        livesSlider.value = GameData.Lives;
        GameData.highscore = GameData.Score;
        if (GameData.Lives == 0) SceneManager.LoadScene("Lose_Screen");
    }

    public void Highscore()
    {
        try
        {
            PlayerHighScore = GameObject.Find("HighScore_Player").GetComponent<Text>();
        }
        catch
        {
            Debug.Log("HighScore Not Found");
        }
        

        if (PlayerHighScore != null)
        {
            PlayerHighScore.text = GameData.highscore.ToString();
        }
        else
        {
            Debug.Log("HighScore Not Found");
        }
        
    }

    public void Score()
    {

        try
        {
            playerScoreText = GameObject.Find("Coin_Score").GetComponent<Text>();
        }
        catch
        {
            Debug.Log("Score Not Found");
        }

        

        if (playerScoreText != null)
        {
            playerScoreText.text = "Score: " + GameData.Score.ToString();
        }
        else
        {
            Debug.Log("Score Not Found");
        }

    }

    public void SliderLives()
    {

        try
        {
            livesSlider = GameObject.Find("Slider").GetComponent<Slider>();
        }
        catch
        {
            Debug.Log("Slider Not Found");
        }

        

        if (livesSlider != null)
        {
            livesSlider.value = GameData.Lives;
        }
        else
        {
            Debug.Log("Slider Not Found");
        }

    }
    public void PlayerPrefab()
    {
        try
        {
            playerPrefab = GameObject.Find("Player").GetComponent<GameObject>();
        }
        catch
        {
            Debug.Log("Slider Not Found");
        }


    }

    public void SaveHighScore()
    {
        if (GameData.Score > GameData.highscore)
        {
            GameData.highscore = GameData.Score;
        }
    }


    //Instantiate(playerPrefab, new Vector3(-4.27f, -2.45f, 0f), Quaternion.identity)
}
