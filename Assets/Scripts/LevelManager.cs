using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class LevelManager : MonoBehaviour {

	private static LevelManager _instance;

	public static LevelManager Instance { get { return _instance; } }
	

	private void Awake()
    {
        DontDestroyOnLoad(this);

		if (_instance != null && _instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			_instance = this;
		}
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

	public void QuitGame()
    {
		
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
		#else
            Application.Quit();
        #endif
	}
}
