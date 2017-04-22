using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score = 0;

	public float spawnRate = 1;
	public GameObject[] Props;
	public Transform spawnPoint;
	public Vector3 rotation;

    public Text scoreText;
	public LevelManager _levelManager;

	private void Start()
	{
		_levelManager = FindObjectOfType<LevelManager>();

		InvokeRepeating("Spawner", 0, spawnRate);
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

	private void Spawner()
	{
		int r = Mathf.RoundToInt(Random.Range(0, Props.Length));
		GameObject clone = Instantiate(Props[r], spawnPoint.position, Quaternion.Euler(rotation));

		clone.transform.parent = spawnPoint;
	}
}
