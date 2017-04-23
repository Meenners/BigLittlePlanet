using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigLittlePlanet
{
    public class Stamina : MonoBehaviour
    {

        public float regeneration = 0.1f;


        private int startSize = 3;
        private int minSize = 1;
        private int maxSize = 6;

        private Vector3 targetScale;
        private Vector3 baseScale;
        private int currScale;

        [HideInInspector]
        public bool staminaReady = true;
        private bool _stamina = true;

        


        // Use this for initialization
        void Start()
        {
            baseScale = transform.localScale;
            //transform.localScale = baseScale * startSize;
            currScale = startSize;
            targetScale = baseScale * startSize;
        }

        // Update is called once per frame
        void Update()
        {

            if (!_stamina)
            {
                transform.localScale = Vector3.MoveTowards(transform.localScale, new Vector3(transform.localScale.x, transform.localScale.y, 0), 0.1F * Time.deltaTime);
                if (transform.localScale.z <= 0)
                {
                    GetComponent<Renderer>().material.color = new Color(1, 0F, 0F);
                    staminaReady = false;
                    _stamina = true;
                }
            }

            if (_stamina && transform.localScale.z < baseScale.z)
            {
              
                transform.localScale = Vector3.MoveTowards(transform.localScale, new Vector3(transform.localScale.x, transform.localScale.y, baseScale.z), regeneration * Time.deltaTime);
                if (transform.localScale.z == baseScale.z)
                {
                    GetComponent<Renderer>().material.color = new Color(0, 0.5F, 0.1F);
                    staminaReady = true;
                }
            }

        }

        public void SpentStamina()
        {
            _stamina = false;
        }

        public bool GetStamina()
        {
            return staminaReady;
        }
    }
}
