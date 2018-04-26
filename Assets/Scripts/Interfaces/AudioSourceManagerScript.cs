﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManagerScript : MonoBehaviour 
{
	public AudioSource audioSourceData, audioSourceBoutons, audioSourceClicksEtTyping, audioSourceCueEmotion, audioSourceMusique;

	AudioSource[] audioSourcesAttachedToTheSoundManager;

	int testINT = 0, currentMarker = 0;

	AudioClip cueEmotion;

	void Awake()
	{
		DetectAudioSources ();

		AssignAudioSourcesStartingValues ();

		currentMarker = 2;
	}

	public void DetectAudioSources()
	{
		audioSourcesAttachedToTheSoundManager = this.gameObject.GetComponents<AudioSource> ();

		audioSourceData = audioSourcesAttachedToTheSoundManager [0];
		//audioSourceData.priority = 102;

		audioSourceBoutons = audioSourcesAttachedToTheSoundManager [1]; 
		//audioSourceBoutons.priority = 153;

		audioSourceClicksEtTyping = audioSourcesAttachedToTheSoundManager [2];
		//audioSourceClicksEtTyping.priority = 204 ;

		audioSourceCueEmotion = audioSourcesAttachedToTheSoundManager [3];
		//audioSourceCueEmotion.priority = 51;

		audioSourceMusique = audioSourcesAttachedToTheSoundManager [4];
		//audioSourceMusique.priority = 0;
	}


	void AssignAudioSourcesStartingValues()
	{
		for (int i = 0; i < audioSourcesAttachedToTheSoundManager.Length; i++) 
		{
			audioSourcesAttachedToTheSoundManager [i].volume = 1.0f;
			audioSourcesAttachedToTheSoundManager [i].priority = 128;
		}
	}

	public void ResetAllAudioSourcesVolumeSliders()
	{
		for (int i = 0; i < audioSourcesAttachedToTheSoundManager.Length; i++)
		{
			audioSourcesAttachedToTheSoundManager [i].volume = 1f;
		}
	}

	IEnumerator CueEmotion()
	{
		audioSourceMusique.volume = 0.0f;

		audioSourceCueEmotion.PlayOneShot (cueEmotion, 1.0f);

		/*float localFloat = audioSourceCueEmotion.clip.length;
		yield return new WaitForSeconds (localFloat);*/

		yield return new WaitForSeconds (audioSourceCueEmotion.clip.length);

		ResetAllAudioSourcesVolumeSliders ();

		//this.gameObject.GetComponent<ChangeMusic> ().PlayNextMusic ();
	}
}


//	public void FadeSoundWhenClickIsPlaying()
//	{
//		StartCoroutine (WhenSoundClickScriptIsBeingCalled());
//	}
//	void Update()
//	{
//		WhenSoundClickScriptIsBeingCalled ();
//		if (Input.GetKeyDown(KeyCode.A)) 
//		{
//			testINT += 1;
//			Debug.Log ("From AudioSourceManagerScript.cs, the current value of testINT is: " + testINT);
////			audioSourceMusique.pitch += .1f;
//		}
//
//		if (Input.GetKeyDown(KeyCode.B)) 
//		{
//			testINT -= 1;
//			Debug.Log ("From AudioSourceManagerScript.cs, the current value of testINT is: " + testINT);
////			audioSourceMusique.pitch -= .1f;
//		}
//	}
//	IEnumerator WhenSoundClickScriptIsBeingCalled()
//	{
//		localAudioSources[0].volume = .7f;
//		localAudioSources[1].volume = .7f;
//		localAudioSources[3].volume = .7f;
//		localAudioSources[4].volume = .7f;
//
//		yield return new WaitForSeconds (localAudioSources[2].time);
//	}
//