using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{

    private static int score;
    private static int lives;
    private static int HighScore;
    private static Vector3 PlayerPos;

    public static int Score
    {
        get { return score; }
        set { score = value; }
    }

    public static int Lives
    {
        get { return lives; }
        set { lives = value; }
    }

    public static Vector3 playerpos
    {
        get { return PlayerPos; }
        set { PlayerPos = value; }
    }

    public static int highscore
    {
        get { return HighScore; }
        set { HighScore = value; }
    }

}
