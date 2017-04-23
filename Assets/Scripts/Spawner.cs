
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

	public float spawnRate = 1;
	public GameObject[] Props;
	public Transform spawnPoint;
	public Vector3 rotation;


	private void Start()
	{
		InvokeRepeating("Spawn", 0, spawnRate);
	}


	private void Spawn()
	{
		int r = Mathf.RoundToInt(Random.Range(0, Props.Length));
		GameObject clone = Instantiate(Props[r], spawnPoint.position, Quaternion.Euler(rotation));

		clone.transform.parent = spawnPoint;
	}
}
