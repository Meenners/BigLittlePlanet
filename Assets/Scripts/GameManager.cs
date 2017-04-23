using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score = 0;
    public Text scoreText;
	public LevelManager _levelManager;

	private void Start()
	{
		_levelManager = FindObjectOfType<LevelManager>();
        
	}

	public void ScorePoints(int points = 1)
    {
        score = score + points;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("score", score);
    }

    public void GameOver()
    {
        if(score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score);
        }

        score = 0;

		_levelManager.LoadLevel(0);
    }

}
