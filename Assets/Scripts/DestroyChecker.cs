using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChecker : MonoBehaviour {

	public float rotationToDestroy = 1f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CheckToDestroy", 0, 0.25f);	
	}
	
	void CheckToDestroy()
	{

		if(transform.rotation.y > rotationToDestroy)
		{
			Destroy(this.gameObject);
		}

		
	}
}
