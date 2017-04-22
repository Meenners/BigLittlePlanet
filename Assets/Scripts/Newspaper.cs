using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigLittlePlanet
{
    public class Newspaper : MonoBehaviour
    {
		public GameObject explosion;
		private GameManager _gamemanager;

        void Start()
        {
			_gamemanager = GameObject.FindObjectOfType<GameManager>();
            Destroy(gameObject, 2F);
        }

        private void Update()
        {
            transform.Rotate(new Vector3(0, 1000 * Time.deltaTime, 0));
        }

		private void OnCollisionEnter(Collision collision)
		{
			if (collision.transform.GetComponent<Target>())
			{
				_gamemanager.ScorePoints(collision.transform.GetComponent<Target>().points);
			}

			Instantiate(explosion, transform.position, Quaternion.identity);
			GetComponent<BoxCollider>().enabled = false;
			Destroy(this.gameObject, 1f);
		}

	}
}
