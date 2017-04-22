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

        #endregion

        #region Private Attributes
        
        #endregion

        void Update()
        {
            //asign to shot
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
                position = Camera.main.ScreenToWorldPoint(position);
                GameObject news = Instantiate(newspaperPrefab, new Vector3( transform.position.x, transform.position.y+arch, transform.position.z), Quaternion.identity) as GameObject;
                news.transform.parent = newpaperPileParent;
                news.transform.LookAt(new Vector3(position.x, 0F, position.z));
                news.GetComponent<Rigidbody>().AddForce(-news.transform.forward * 1000);
            }
        }
    }
}
