using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.layer == 9 || collision.gameObject.layer == 10)
		{
			return;
		} else
		{
			Destroy(collision.gameObject);
			GetComponent<AudioSource>().Play();
		}
	}
}
