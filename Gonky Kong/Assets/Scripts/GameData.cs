using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{

    private static int score;
    private static int lives;

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

}
