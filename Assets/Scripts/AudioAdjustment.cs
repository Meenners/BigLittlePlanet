using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioAdjustment : MonoBehaviour {

	public AudioMixer mixer;

	public void SetSFXLevel(float volume)
	{
		mixer.SetFloat("SoundFX", volume);
	}

	public void SetMusicLevel(float volume)
	{
		mixer.SetFloat("Master", volume);
	}
}
