using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class ChangeMusic : MonoBehaviour
{	
	public AudioClip[] clipList;

	AudioSource audioSource;
	int currentAudioIndex = 0;
	bool isAudioPlaying;

	void Start()
	{
		isAudioPlaying = true;

		audioSource = GetComponent<AudioSource>();

		audioSource.Stop ();

		audioSource.clip = clipList[currentAudioIndex];

		audioSource.Play ();
	}

	void PlayMusicAtIndex(int k)
	{
		if (k >= clipList.Length && k < 0) 
		{
			return;
		}
		audioSource.Stop ();
		currentAudioIndex = k;
		audioSource.clip = clipList[currentAudioIndex];
		audioSource.Play ();
	}

	void PlayNextMusic()
	{
		int k = (currentAudioIndex + 1) % clipList.Length;
		PlayMusicAtIndex(k);
	}

	void PlayPreviousMusic()
	{
		int k = (currentAudioIndex - 1) % clipList.Length;

		if (k <= 0) 
		{
			k = 0;
		}

		PlayMusicAtIndex(k);
	}
		
	void Update()
	{		
		if (audioSource.time == audioSource.clip.length) 
		{
			Debug.Log (audioSource.clip.name + " a terminer de jouer");
			PlayNextMusic ();
		}
	}
}
