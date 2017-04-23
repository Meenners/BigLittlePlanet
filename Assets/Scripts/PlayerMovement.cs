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

			//Debug.DrawRay(transform.position, Vector3.down, Color.red);

			//RaycastHit hit;

			//if (Physics.Raycast(transform.position, -Vector3.up * 2, out hit))
			//{
			//	Vector3 dest = Vector3.MoveTowards(transform.position, hit.point, 1f);

			//	transform.position = dest;
			//}

			//worldRotation.UpdateRotationSpeed(_dir.z * 10);

		}
    }
}
