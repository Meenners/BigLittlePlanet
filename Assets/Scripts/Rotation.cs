
using UnityEngine;

namespace BigLittlePlanet
{
    public class Rotation : MonoBehaviour
    {

        #region Public Attributes
        public float rotationSpeed = 10.0F;
        private float currentSpeed;
        #endregion

        private void Start()
        {
            currentSpeed = rotationSpeed;
        }

        void Update()
        {
            transform.Rotate(new Vector3(0, -currentSpeed * Time.deltaTime, 0));
        }

        public void UpdateRotationSpeed(float amount)
        {
            //TABLE-NG
             //currentSpeed += amount;
             //Debug.Log("current sppedd:" + currentSpeed);
        }
    }
}
