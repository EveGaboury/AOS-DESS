using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DataPrefab : MonoBehaviour
{  
	//Public
	public Sprite finalSprite;

	public string currentlyPlayingClip;

	public AudioClip clipToBePlayed;

	public AnimationClip animCLIP;

	public float changeLeVolumeDeLaTune = 0.66f;

	[HideInInspector]
	public bool animClipIsPlaying = false, justAnotherBoool = true;

	//Private
	Animator animator;

	float nextFire = 0.0f, timeIncrement = 0.0f; 

	bool isAudioClipPlaying;

	AudioSource ASMS_Data;

	GameObject localGameObject;

	float MusicVolume = 1.0f;

	void Start()
	{
		animator = GetComponent<Animator> ();

		localGameObject = GameObject.Find ("SoundManager");

		ASMS_Data = localGameObject.gameObject.GetComponent<AudioSourceManagerScript> ().audioSourceData;
	}

	void FixedUpdate()
	{
		if (animClipIsPlaying == true) 
		{
			justAnotherBoool = false;

			CheckIfClipIsDonePlaying ();
		}

		if ((this.gameObject.GetComponent<Button> () != null) && (ASMS_Data.isPlaying == true)) 
		{
			this.gameObject.GetComponent<Button> ().enabled = false; 
		} 
		else if ((this.gameObject.GetComponent<Button> () != null) && (ASMS_Data.isPlaying == false))
		{
			this.gameObject.GetComponent<Button> ().enabled = true; 
		}

		if (ASMS_Data.clip == clipToBePlayed) 
		{
			Invoke ("ResetVolumeValues", ASMS_Data.clip.length);

			//Debug.Log ("la cue d'emotion " + cue_emotion_1 + " est entrain de jouer.");
		}
	}

	void CheckIfClipIsDonePlaying()
	{
		if (animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName (currentlyPlayingClip) &&
			animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1.0f) 
		{
			animClipIsPlaying = false;

			animator.SetBool ("onClick", false);

			if (animClipIsPlaying == false && justAnotherBoool == false) 
			{
				CreateButtonAndAssignScript ();

				//StartCoroutine (PlayAudio ());

				StartCoroutine (PlayAudio (clipToBePlayed));

				this.gameObject.GetComponent<Image> ().overrideSprite = finalSprite;
			}
		}
	}

//	IEnumerator PlayAudio()
//	{
//		localGameObject.gameObject.GetComponent<AudioSourceManagerScript> ().audioSourceMusique.volume = changeLeVolumeDeLaTune;
//
//		ASMS_Data.PlayOneShot (clipToBePlayed, 0.5f);
//
//		float localFloat = clipToBePlayed.length;
//
//		yield return new WaitForSeconds (localFloat);
//
//		localGameObject.gameObject.GetComponent<AudioSourceManagerScript> ().ResetAllAudioSourcesVolumeSliders ();
//	}

	public void PlaySoundOnceButtonInstantiated()
	{
		ASMS_Data.Stop ();

		//StartCoroutine (PlayAudio ());

		StartCoroutine (PlayAudio (clipToBePlayed));
	}

	void CreateButtonAndAssignScript()
	{
		Button btn = this.gameObject.AddComponent<Button> () as Button;

		btn.GetComponent<Button>().onClick.AddListener(PlaySoundOnceButtonInstantiated); 
	}

	IEnumerator PlayAudio(AudioClip tuneToPlay)
	{
		ASMS_Data.PlayOneShot (tuneToPlay);

		StartCoroutine(CrossFadeBetweenTunes(localGameObject.gameObject.GetComponent<AudioSourceManagerScript> ().audioSourceMusique, ASMS_Data, 1.0f));

		float localFloat = tuneToPlay.length;

		yield return new WaitForSeconds (localFloat);

		ASMS_Data.clip = null;
	}

	IEnumerator CrossFadeBetweenTunes (AudioSource a, AudioSource b, float seconds)
	{
		float step_interval = seconds / 1.0f;

		float volume_interval = MusicVolume / 5.0f;

		for (int i = 0; i < 20; i++) 
		{
			a.volume -= volume_interval;
			b.volume += volume_interval;

			yield return new WaitForSeconds (step_interval);
		}
	}
}