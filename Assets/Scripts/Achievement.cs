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
	private int peopleCount = 0;
	private int birdCount = 0;
    private int carCount = 0;
    private int dogCount = 0;

    private int totalPoints = 0;

    // Use this for initialization
    void Start () {
        achievementHolder.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Check(int points)
    {
        totalPoints += points;
        if(totalPoints > 100 )


        //home achievements
        if(points == 10)
        {
            houseCount++;
            if (houseCount == 5)
            {
                GotAchievement("Home Sweet Home", "Delivered To 5 Houses");
            }

            if (houseCount == 20)
            {
                GotAchievement("Home Wrecker!", "Delivered To 20 Houses");
            }

            if (houseCount == 50)
            {
                GotAchievement("Curve Grinder!!", "Delivered To 50 Houses");
            }

            if (houseCount == 100)
            {
                GotAchievement("Window Smasher!!!", "Delivered To 100 Houses");
            }
        }

        //business achievements
        if (points == 2)
        {
            businessCount++;

            if (businessCount == 5)
            {
                GotAchievement("Intern", "Delivered To 5 Businesses");
            }

            if (businessCount == 50)
            {
                GotAchievement("PC Load Letter!", "Delivered To 50 Businesses");
            }

            if (businessCount == 100)
            {
                GotAchievement("Straight Shooter!!", "Delivered To 100 Businesses");
            }

            if (businessCount == 200)
            {
                GotAchievement("CEO Promotion!!!", "Delivered To 200 Businesses");
            }
        }


        //people achievements
		if(points == 7)
		{
			peopleCount++;
			if(peopleCount == 5)
			{
				GotAchievement("Nice To Meet You", "5 Personal Deliveries");
			}

            if (peopleCount == 20)
            {
                GotAchievement("Nice Catch!", "20 Personal Deliveries");
            }

            if (peopleCount == 50)
            {
                GotAchievement("Paper Cut!!", "50 Personal Deliveries");
            }

            if (peopleCount == 100)
            {
                GotAchievement("High Fives!!!", "100 Personal Deliveries");
            }
        }

        //birds achievements
		if(points == 20)
		{
			birdCount++;
			if(birdCount == 1)
			{
				GotAchievement("Bird Watcher", "You Hit 1 Bird, You Monster.");
			}

            if (birdCount == 5)
            {
                GotAchievement("2 Birds, 1 Stone!", "You Hit 5 Birds, You Monster.");
            }

            if (birdCount == 10)
            {
                GotAchievement("Pidgeon Slayer!!", "You Hit 10 Birds, You Monster.");
            }

            if (birdCount == 15)
            {
                GotAchievement("Eagle Eyes!!!", "You Hit 15 Birds, You Monster.");
            }
        }


        //car achievements
		if(points == 5)
		{
			carCount++;
			if(carCount == 15)
			{
				GotAchievement("Bumper to Bumper", "Delivered Directly Into 15 Cars");
			}

            if (carCount == 30)
            {
                GotAchievement("Road Rage!", "Delivered Directly Into 30 Cars");
            }

            if (carCount == 50)
            {
                GotAchievement("Freaky Fast!!", "Delivered Directly Into 50 Cars");
            }

            if (carCount == 100)
            {
                GotAchievement("88 MPH!!!", "Delivered Directly Into 100 Cars");
            }
        }

        //dog achievements
        if (points == 15)
        {
            dogCount++;
            if (dogCount == 1)
            {
                GotAchievement("Puppy Trainer", "Delivered Directly To 1 Dog");
            }

            if (dogCount == 5)
            {
                GotAchievement("Dog Whisperer!", "Delivered Directly To 5 Dogs");
            }

            if (dogCount == 10)
            {
                GotAchievement("Dog Lover!!", "Delivered Directly To 10 Dogs");
            }

            if (dogCount == 100)
            {
                GotAchievement("Cesar Millan!!!", "Delivered Directly To 100 Dogs");
            }
        }

    }


    void GotAchievement(string title, string description)
    {
        achievementHolder.SetActive(true);

        //this is ugly
        PlayerPrefs.SetString(title, description);


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
