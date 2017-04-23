using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigLittlePlanet
{
    public class PlayerMovement : MonoBehaviour
    {
        #region Public Attributes
        public float movementSpeed = 2.0F;
        public Rotation worldRotation;
        #endregion

        #region Private Attributes
        private Vector3 _dir = Vector3.zero;
        #endregion

        void FixedUpdate()
        {
            _dir.x = Input.GetAxis("Horizontal");
            _dir.z = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(_dir.x, 0, 0);
            transform.position += direction * movementSpeed * Time.deltaTime;

           
            //worldRotation.UpdateRotationSpeed(_dir.z * 10);

        }
    }
}
