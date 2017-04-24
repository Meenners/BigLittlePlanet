using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AchievementList : MonoBehaviour {

    public GameObject achievementPrefab;

    //omg use dictionary, not this!!!!
    private List<string> achievements = new List<string>(
        new string[] {"Home Sweet Home", "Home Wrecker!", "Curve Grinder!!", "Window Smasher!!!",
        "Intern", "PC Load Letter!", "Straight Shooter!!", "CEO Promotion!!!",
        "Nice To Meet You", "Nice Catch!", "Paper Cut!!", "High Fives!!!",
        "Bird Watcher", "2 Birds, 1 Stone!", "Pidgeon Slayer!!", "Eagle Eyes!!!",
        "Bumper to Bumper", "Road Rage!", "Freaky Fast!!", "88 MPH!!!",
        "Puppy Trainer", "Dog Whisperer!", "Dog Lover!!", "Cesar Millan!!!"
        });
    
    private List<string> achievementsDescription = new List<string>(
        new string[] { "Delivered To 5 Houses", "Delivered To 20 Houses", "Delivered To 50 Houses", "Delivered To 100 Houses",
        "Delivered To 5 Businesses", "Delivered To 50 Businesses", "Delivered To 100 Businesses", "Delivered To 200 Businesses",
        "5 Personal Deliveries", "20 Personal Deliveries", "50 Personal Deliveries", "100 Personal Deliveries",
        "You Hit 1 Bird, You Monster.", "You Hit 5 Birds, You Monster.", "You Hit 10 Birds, You Monster.", "You Hit 15 Birds, You Monster.",
        "Delivered Directly Into 15 Cars", "Delivered Directly Into 30 Cars", "Delivered Directly Into 50 Cars", "Delivered Directly Into 100 Cars",
        "Delivered Directly To 1 Dog", "Delivered Directly To 5 Dogs", "Delivered Directly To 10 Dogs", "Delivered Directly To 100 Dogs"
        });


    // Use this for initialization
    void Start () {
        for(int x=0; x < 24; x++) { 
            GameObject ac = Instantiate(achievementPrefab, transform);
            ac.transform.GetChild(0).GetComponent<Text>().text = achievements[x];
            ac.transform.GetChild(1).GetComponent<Text>().text = achievementsDescription[x];

            if(PlayerPrefs.HasKey(achievements[x]))
            {
                ac.GetComponent<Image>().color = Color.yellow;
            }
        }

    }
	
	// Update is called once per frame
	void Update () {

    }


}
