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

	public float changeLeVolumeDeLaTune = 0.3f;

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

				StartCoroutine (PlayAudio ());

				this.gameObject.GetComponent<Image> ().overrideSprite = finalSprite;
			}
		}
	}

	IEnumerator PlayAudio()
	{
		ASMS_Data.PlayOneShot (clipToBePlayed, 0.5f);

		localGameObject.gameObject.GetComponent<AudioSourceManagerScript> ().audioSourceMusique.volume = changeLeVolumeDeLaTune;

		float localFloat = clipToBePlayed.length;

		yield return new WaitForSeconds (localFloat);

		localGameObject.gameObject.GetComponent<AudioSourceManagerScript> ().ResetAllAudioSourcesVolumeSliders ();
	}

	public void PlaySoundOnceButtonInstantiated()
	{
		ASMS_Data.Stop ();

		StartCoroutine (PlayAudio ());
	}

	void CreateButtonAndAssignScript()
	{
		Button btn = this.gameObject.AddComponent<Button> () as Button;

		btn.GetComponent<Button>().onClick.AddListener(PlaySoundOnceButtonInstantiated); 
	}
}