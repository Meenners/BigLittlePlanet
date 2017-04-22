using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigLittlePlanet
{
    public class PlayerShoot : MonoBehaviour
    {

        #region Public Attributes
        public GameObject newspaperPrefab;
        public float speed;
        public float rotationSpeed;
        public Transform newpaperPileParent;

        #endregion

        #region Private Attributes
        private Vector2 _dir = Vector2.zero;
        #endregion

        void Start()
        {

        }

        void Update()
        {
            _dir.x = Input.GetAxis("Mouse X");
            _dir.x = Input.GetAxis("Mouse Y");

            //asign to shot
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log(_dir.x);
                GameObject newspaper = Instantiate(newspaperPrefab, new Vector3(0.5F,0.5F, 0.5F), Quaternion.identity);
                newspaper.transform.parent = newpaperPileParent;
                Rigidbody rbNewspaper = newspaper.GetComponent<Rigidbody>();

                //replace with direction later
                rbNewspaper.AddForce(transform.rotation * _dir * speed, ForceMode.Impulse);

                newspaper.transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
            }
        }




    }
}
