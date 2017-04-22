using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigLittlePlanet
{
    public class Newspaper : MonoBehaviour
    {

        void Start()
        {
            Destroy(gameObject, 2F);
        }

        private void Update()
        {
            transform.Rotate(new Vector3(0, 1000 * Time.deltaTime, 0));
        }

    }
}
