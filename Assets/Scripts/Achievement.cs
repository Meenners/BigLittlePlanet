using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour {

    public GameObject achievementHolder;
    public Text titleText;
    public Text descriptionText;

    private int houseCount = 0;
    private int businessCount = 0;

    // Use this for initialization
    void Start () {
        achievementHolder.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Check(int points)
    {
        if(points == 10)
        {
            houseCount++;
            if(houseCount == 10)
            {
                GotAchievement("Home Wrecker", "10 Houses Delivered");
            }
        }

        if (points == 1)
        {
            businessCount++;
            if (businessCount == 20)
            {
                GotAchievement("Synergy", "20 Busineses Delivered");
            }
        }

    }


    void GotAchievement(string title, string description)
    {
        achievementHolder.SetActive(true);
        titleText.text = title;
        descriptionText.text = description;

        StartCoroutine(HideThis());

    }

    IEnumerator HideThis()
    {
        yield return new WaitForSeconds(4F);
        achievementHolder.SetActive(false);
    }
}
