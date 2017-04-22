﻿
using UnityEngine;

namespace BigLittlePlanet
{
    public class Rotation : MonoBehaviour
    {

        #region Public Attributes
        public float rotationSpeed = 20.0F;
        #endregion
        
        void Update()
        {
            transform.Rotate(new Vector3(0, -rotationSpeed * Time.deltaTime, 0));
        }
    }
}