using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score = 0;

    public Text scoreText;

    public void ScorePoints(int points = 1)
    {
        score = score + points;
        scoreText.text = score.ToString();
    }
}
