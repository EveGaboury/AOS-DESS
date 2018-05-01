using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManagerScript : MonoBehaviour 
{
	public float resetVolumeValueAfterPlayingSound = 0.3f;

	public AudioSource audioSourceData, audioSourceBoutons, audioSourceClicksEtTyping, audioSourceCueEmotion, audioSourceMusique;

	AudioSource[] audioSourcesAttachedToTheSoundManager;

	AudioClip cueEmotion;

	void Awake()
	{
		DetectAudioSources ();
	}

	public void DetectAudioSources()
	{
		audioSourcesAttachedToTheSoundManager = this.gameObject.GetComponents<AudioSource> ();

		audioSourceData = audioSourcesAttachedToTheSoundManager [0];

		audioSourceBoutons = audioSourcesAttachedToTheSoundManager [1]; 

		audioSourceClicksEtTyping = audioSourcesAttachedToTheSoundManager [2];

		audioSourceCueEmotion = audioSourcesAttachedToTheSoundManager [3];

		audioSourceMusique = audioSourcesAttachedToTheSoundManager [4];
	}

	public void ResetAllAudioSourcesVolumeSliders()
	{
		for (int i = 0; i < audioSourcesAttachedToTheSoundManager.Length; i++)
		{
			audioSourcesAttachedToTheSoundManager [i].volume = resetVolumeValueAfterPlayingSound;
		}
	}
}