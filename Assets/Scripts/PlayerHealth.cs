﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 9 || other.gameObject.layer == 10)
		{
			return;
		}
		else
		{
			Destroy(other.gameObject);


			if(other.gameObject.name == "CarOne")
				GetComponent<AudioSource>().Play();
		}
	}
}
