using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class LevelManager : MonoBehaviour {

	private static LevelManager _instance;

	public static LevelManager Instance { get { return _instance; } }

    public GameObject achievementPanel;

    public Text score;

    private void Start()
    {

		if(SceneManager.GetActiveScene().buildIndex == 1)
		{
			return;
		}

        if(!PlayerPrefs.HasKey("highscore"))
        {
            score.text = "0";
        } else
        {
            score.text = PlayerPrefs.GetInt("highscore").ToString();
        }

        if(achievementPanel)
            achievementPanel.SetActive(false);
    }

    private void Awake()
    {
  //      DontDestroyOnLoad(this);

		//if (_instance != null && _instance != this)
		//{
		//	Destroy(this.gameObject);
		//}
		//else
		//{
		//	_instance = this;
		//}
	}

    public void LoadLevel(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			QuitGame();
		}
	}

    public void ShowAchievements()
    {
        achievementPanel.SetActive(true);
    }

    public void HideAchievements()
    {
        achievementPanel.SetActive(false);
    }

    public void QuitGame()
    {
		
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
		#else
            Application.Quit();
        #endif
	}
}
