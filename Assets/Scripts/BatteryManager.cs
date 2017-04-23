using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryManager : MonoBehaviour {

	private GameManager _gameManager;
	public GameObject pickupEffect;

	private void Start()
	{
		_gameManager = FindObjectOfType<GameManager>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player")
		{
			Instantiate(pickupEffect, transform.position, Quaternion.identity);

			_gameManager.AddBattery();

			Destroy(this.gameObject, 0.1f);
		}
	}
}
