using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManagerScript : MonoBehaviour 
{
	public AudioSource audioSourceData, audioSourceBoutons, audioSourceClicksEtTyping, audioSourceCueEmotion, audioSourceMusique;

	void Awake()
	{
		DetectAudioSources ();
	}

	public void DetectAudioSources()
	{
		AudioSource[] localAudioSources = this.gameObject.GetComponents<AudioSource> ();

		audioSourceData = localAudioSources [0];

		audioSourceBoutons = localAudioSources [1]; 

		audioSourceClicksEtTyping = localAudioSources [2];

		audioSourceCueEmotion = localAudioSources [3];

		audioSourceMusique = localAudioSources [4];
	}
}