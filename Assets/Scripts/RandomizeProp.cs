using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeProp : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //wtf not workin???? TODO:
        transform.position = new Vector3(transform.position.x, Random.Range(-2, 2), transform.position.z);
    }
}
