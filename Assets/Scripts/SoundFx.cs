using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigLittlePlanet
{
    public class SoundFx : MonoBehaviour
    {

        #region Public Attributes
        public AudioClip audioClip;
        #endregion

        #region Private Attributes
        private AudioSource _audioSource { get { return GetComponent<AudioSource>();  } }
        #endregion

        void Start()
        {
            gameObject.AddComponent<AudioSource>();
            _audioSource.clip = audioClip;
            _audioSource.playOnAwake = true;
        }

        public void Play()
        {
            _audioSource.PlayOneShot(audioClip);
        }
    }
}
