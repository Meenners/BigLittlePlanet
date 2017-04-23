using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;
	private Vector3 origin;

	private void Start()
	{
		origin = target.transform.position;
	}

	// Update is called once per frame
	void Update () {

		Vector3 dest = Vector3.Lerp(target.position, origin, 0.2f);

		transform.LookAt(dest);
	}
}
