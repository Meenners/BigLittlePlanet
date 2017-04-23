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

				Target myTarg = collision.transform.GetComponent<Target>();

				_gamemanager.ScorePoints(myTarg.points);

				if (myTarg.destroyOnContact)
				{
					Destroy(collision.gameObject);
                    

                }

                GameObject explo = Instantiate(explosion, transform.position, Quaternion.identity);
                explo.GetComponent<HitParticleController>().hitpoints = myTarg.points;

            }

			GetComponent<BoxCollider>().enabled = false;
			Destroy(this.gameObject, 1f);
		}

	}
}
