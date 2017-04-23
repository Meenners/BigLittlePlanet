using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigLittlePlanet
{
    public class PlayerShoot : MonoBehaviour
    {

        #region Public Attributes
        public GameObject newspaperPrefab;
        public float arch = 0.4F;
        public float distance = 10F;
        public Transform newpaperPileParent;

        public Stamina stamina;

        public Animator throwAnimation;

		#endregion

		#region Private Attributes
		private AudioSource _aud;
		#endregion

		private void Start()
		{
			_aud = GetComponent<AudioSource>();
		}

		void Update()
        {
            //asign to shot
            if (Input.GetMouseButtonDown(0) && stamina.GetStamina())
            {
                stamina.SpentStamina();

                //TODO
                throwAnimation.SetBool("throw", true);
				_aud.Play();

                Vector3 position = new Vector3(Input.mousePosition.x, -Input.mousePosition.y, distance);
                position = Camera.main.ScreenToWorldPoint(position);
                GameObject news = Instantiate(newspaperPrefab, new Vector3( transform.position.x, transform.position.y+arch, transform.position.z), Quaternion.identity) as GameObject;
                news.transform.parent = newpaperPileParent;
                news.transform.LookAt(new Vector3(-position.x * 6, 0F, position.z));
                news.GetComponent<Rigidbody>().AddForce(-news.transform.forward * 1000);

                //TODO
                throwAnimation.SetBool("throw", false);
            }
        }
    }
}
