using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryManager : MonoBehaviour {

	private GameManager _gameManager;

	private void Start()
	{
		_gameManager = FindObjectOfType<GameManager>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player")
		{
			Debug.Log("got a battery");

			_gameManager.AddBattery();

			Destroy(this.gameObject);
		}
	}
}
