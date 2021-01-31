using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text playerScoreText;

    [SerializeField] Text livesText;
    [SerializeField] Slider livesSlider;

    [SerializeField] GameObject playerPrefab;

    SaveManager MySaveManager;

    // Start is called before the first frame update
    void Start()
    {
        GameData.Score = 0;
        GameData.Lives = 4;
        MySaveManager = GetComponent<SaveManager>();

        MySaveManager.LoadData();


        playerScoreText.text = "Score: " + GameData.Score.ToString();
        livesSlider.value = GameData.Lives;

    }

    // Update is called once per frame
    void Update()
    {
        MySaveManager.SaveMyData();
    }

    public void PlayerDie()
    {
        GameData.Lives--;
        livesSlider.value = GameData.Lives;
        if (GameData.Lives == 0) SceneManager.LoadScene("Lose_Screen");
    }


    //Instantiate(playerPrefab, new Vector3(-4.27f, -2.45f, 0f), Quaternion.identity)
}
