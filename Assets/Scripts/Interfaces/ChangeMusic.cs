using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using System.Linq;

[RequireComponent(typeof(AudioSource))]
public class ChangeMusic : MonoBehaviour
{	
	public Button activatingButton;
	public AudioClip[] clipList;

	public GameObject testingThis;
	public Transform testingLocation;

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
		TextMeshProUGUI displayText = gameObject.GetComponentInChildren (typeof(TextMeshProUGUI)) as TextMeshProUGUI;

		if (displayText != null)
		{
			displayText.text = "";
			GameObject test = Instantiate(testingThis, testingLocation.localPosition, Quaternion.identity) as GameObject;
			for (int i = 0; i < clipList.Length; i++) 
			{
				//displayText.text = clipList [0].name + "\r\n" + clipList [1].name ;

				Debug.Log (clipList [i].name);
			}

			Debug.Log (displayText.gameObject.name);
		} 
		else
		{
			return;
		}
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
}
