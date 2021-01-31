using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;


    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = GameData.Score;
        MyScoreText.text = "Score : " + ScoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Coin_Score)
    {
        if(Coin_Score.tag == "Coin")
        {
            ScoreNum += 1;
            GameData.Score = ScoreNum;
            Destroy(Coin_Score.gameObject);
            MyScoreText.text = "Score : " + ScoreNum;
        }
    }

}
