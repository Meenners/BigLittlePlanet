﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score = 0;
	public int battery = 100;
    public Text scoreText;
	public Image batteryFill;
	public LevelManager _levelManager;
    public GameObject GameOverText;
    public Achievement Achievements;

	private void Start()
	{
		_levelManager = FindObjectOfType<LevelManager>();
		InvokeRepeating("UpdateBattery", 0, 1f);
	}

	public void ScorePoints(int points = 1)
    {
        Achievements.Check(points);

        score = score + points;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("score", score);
    }

	public void UpdateBattery()
	{
		battery -= 3;
		batteryFill.fillAmount = battery * 0.01f;

		if(battery <= 0)
		{
			GameOver();
		}
	}

	public void AddBattery()
	{
		battery += 50;

		if(battery > 100)
		{
			battery = 100;
		}

		batteryFill.fillAmount = battery;
	}

    public void GameOver()
    {
        if(score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score);
        }

        

        GameOverText.SetActive(true);
        
        StartCoroutine(Reset());

		
    }

    IEnumerator Reset()
    {
        Time.timeScale = 0.1F;
        yield return new WaitForSeconds(0.5F);
        score = 0;
        Time.timeScale = 1F;
        _levelManager.LoadLevel(0);
    }

}
