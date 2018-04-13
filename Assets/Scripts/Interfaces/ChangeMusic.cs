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
	//Public
	public AudioClip[] clipList, cueEmotion;

	public GameObject displayTitle;

	public AudioSource audioSource1, audioSource2;

	//Private
	List<GameObject> listeNomsChansons = new List<GameObject> ();

	AudioSource audioSource;

	int currentAudioIndex = 0;

	bool isAudioPlaying;

	GameObject canvasEve, iTunes;

	Color initialColor, isPlayingColor;

	void Awake()
	{
		isAudioPlaying = true;

		//audioSource = GetComponent<AudioSource>();

		iTunes = GameObject.Find ("iTunesCanvas");

		RetrieveAllChildrenGameObjectsOfiTunes ();
	}

	void Start() 
	{
		DetectAudioSources ();

		audioSource1.clip = clipList[currentAudioIndex]; 

		audioSource1.Stop ();

		audioSource1.clip = clipList[currentAudioIndex];

		audioSource1.Play ();

		canvasEve = GameObject.Find ("CanvasEve");

		initialColor = Color.white;

		isPlayingColor = Color.green; 

		HighlightCurrentlyPlayingSongButton ();

		//ActivateAndDeactive ();
	}

	void Update() 
	{
		CrossFadeBetweenTunes (); 

		if ((audioSource1.isPlaying == true)/* && (audioSource1.time <= .5f)*/) 
		{
			StartCoroutine (DisplayCurrentlyPlayingSongName()); 
			//Debug.Log ("AudioSource is playing: " + audioSource1.clip.name);
		}

		if (audioSource1.time == audioSource1.clip.length) 
		{
			PlayNextMusic ();
		}
	}

	public void PlayMusicAtIndex(int k)
	{
		if (k >= clipList.Length && k < 0) 
		{
			return;
		}

		audioSource1.Stop ();

		currentAudioIndex = k;

		audioSource1.clip = clipList[currentAudioIndex];

		audioSource1.Play ();

		HighlightCurrentlyPlayingSongButton ();
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

	public void RandomizeNextSong()
	{
		//Do the thingy!
	}

	public void ActivateAndDeactive()
	{
		if (iTunes.gameObject.activeSelf == true) 
		{
			iTunes.gameObject.SetActive (false);
		}
		else if (iTunes.gameObject.activeSelf == false) 
		{
			iTunes.gameObject.SetActive (true);
		}
	}

	void HighlightCurrentlyPlayingSongButton() 
	{
		for (int k = 0; k < listeNomsChansons.Count; k++)
		{
			if (audioSource1.clip.name == clipList [k].name)
			{
				listeNomsChansons [k].GetComponent<Image> ().color = isPlayingColor;
			}  
			else
			{
				listeNomsChansons [k].GetComponent<Image> ().color = initialColor;
			}
		}
	}

	IEnumerator DisplayCurrentlyPlayingSongName()
	{
		displayTitle.SetActive (true);

		displayTitle.GetComponentInChildren<TextMeshProUGUI> ().text = audioSource1.clip.name;

		yield return new WaitForSeconds (5.0f);

		displayTitle.SetActive (false);
	}

	void CrossFadeBetweenTunes ()
	{
		if (audioSource1.isPlaying)
		{
			//Si la chanson est à 10% de la fin
			if (audioSource1.time >= ((audioSource1.clip.length / 10) * 9)) 
			{
				if (audioSource1.volume >= 0.0f) 
				{
					audioSource1.volume -= Time.deltaTime;
				}
			}
			//Si la chanson est à 10% commencée
//			else if (audioSource1.time <= (audioSource.clip.length / 10)) 
//			{
//				if (audioSource1.volume <= 1.0f)
//				{
//					audioSource1.volume += Time.deltaTime;
//				}
//			}
		}
	}

//	public void FadeInFadeOutCueEmotion()
//	{
//		for (int j = 0; j < clipList.Length; j++)
//		{
//			if (clipList[j] && audioSource1.isPlaying == true) 
//			{
//				/*audioSource1.volume = .5f;*/
//
//				/*audioSource2.PlayOneShot(cueEmotion [j]);*/
//					
//				int j = [j];
//				StartCoroutine(FadeCueEmotion(j));
//
//				/*audioSource1.volume = 1.0f;*/
//			}
//		}
//	}

//	IEnumerator FadeCueEmotion(int j)
//	{
//     	audioSource1.volume = .5f;
//		audioSource2.PlayOneShot(cueEmotion [j]);
//		yield return new WaitForSeconds (5.0f);
//		audioSource1.volume = 1.0f;
//	}

	void DetectAudioSources()
	{
		AudioSource[] localAudioSources = this.gameObject.GetComponents<AudioSource> ();

		audioSource1 = localAudioSources [0];

		audioSource2 = localAudioSources [1]; 

		//Debug.Log ("Sur l'objet " + name + " il y a: " + localAudioSources.Length + " AudioSources().");
	}

	void RetrieveAllChildrenGameObjectsOfiTunes()
	{
		Transform[] allChildrenOfThisGameObject = iTunes.gameObject.GetComponentsInChildren<Transform>(true);

		foreach (Transform child in allChildrenOfThisGameObject) 
		{
			if (child.GetComponent<Image>() != null && child.name.Contains("Button_")) 
			{
				listeNomsChansons.Add (child.gameObject);
			}
		}

		for (int i = 0; i < listeNomsChansons.Count; i++) 
		{
			listeNomsChansons [i].GetComponentInChildren<TextMeshProUGUI> ().text = "<size=18>" + clipList [i].name + "</size>";
		}
	}
} 