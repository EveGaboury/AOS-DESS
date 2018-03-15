﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using System.Linq;

[RequireComponent(typeof(AudioSource))]
public class ChangeMusic : MonoBehaviour
{	
	//public Button activatingButton;
	public AudioClip[] clipList;

	public List<GameObject> testList = new List<GameObject> ();

	AudioSource audioSource;
	int currentAudioIndex = 0;
	bool isAudioPlaying;

	void Awake()
	{
		isAudioPlaying = true;

		audioSource = GetComponent<AudioSource>();

		audioSource.Stop ();

		audioSource.clip = clipList[currentAudioIndex];

		audioSource.Play ();
	}

	void Start() 
	{
		RetrieveAllButtons ();
	}

	public void PlayMusicAtIndex(int k)
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

	public void PlayNextMusic()
	{
		int k = (currentAudioIndex + 1) % clipList.Length;
		PlayMusicAtIndex(k);
	}

	public void PlayPreviousMusic()
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

	public void ActivateAndDeactivateMusicInterface()
	{
		if (this.gameObject.activeSelf) 
		{
			this.gameObject.SetActive (false);
			Debug.Log (gameObject.name + " is active");
		} 
		else 
		{
			this.gameObject.SetActive (true);
			Debug.Log (gameObject.name + " is inactive");
		}
	}

	void RetrieveAllButtons()
	{
		Component[] displayText;

		displayText = GetComponentsInChildren (typeof(TextMeshProUGUI));

		if (displayText != null)
		{
			foreach (TextMeshProUGUI item in displayText)
			{
				testList.Add (item.gameObject);
//				Debug.Log (testList.Count);

//				item.text = "";
//				item.text = item.gameObject.name;
//
//				if (displayText.Length <= clipList.Length) 
//				{
//					Debug.Log ("l'array displayText est de taille: " + displayText.Length + " donc est plus PETIT ou egal a la taille de l'array clipList: " + clipList.Length);
//				} 
//				else 
//				{
//					Debug.Log ("l'array displayText est de taille: " + displayText.Length + " donc est plus GRAND ou egal a la taille de l'array clipList: " + clipList.Length);
//				}
			}
		} 
		else
		{
			return;
		}
	}

	public void PauseAndUnpauseMusic()
	{
		if (audioSource != null) 
		{
			if (audioSource.isPlaying) 
			{
				audioSource.Pause ();	
			} 
			else 
			{
				audioSource.UnPause ();
			}		
		}
	}
}
