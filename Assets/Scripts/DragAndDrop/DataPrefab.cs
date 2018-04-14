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

	[HideInInspector]
	public bool animClipIsPlaying = false, justAnotherBoool = true;

	//Private
	Animator animator;

	float nextFire = 0.0f, timeIncrement = 0.0f; 

	bool isAudioClipPlaying;

	AudioSource ASMS_Data;

	void Start()
	{
		animator = GetComponent<Animator> ();

		GameObject localGameObject = GameObject.Find ("SoundManager");

		ASMS_Data = localGameObject.gameObject.GetComponent<AudioSourceManagerScript> ().audioSourceData;
	}

	void Update()
	{
		if (animClipIsPlaying == true) 
		{
			justAnotherBoool = false;

			CheckIfClipIsDonePlaying ();
		}

		if ((this.gameObject.GetComponent<Button> () != null) 
			&& (ASMS_Data.isPlaying == true) 
			/*&& (soundManager.GetComponent<AudioSource> ().clip.name == clipToBePlayed.name)*/) 
		{
			this.gameObject.GetComponent<Button> ().enabled = false; 
		} 
		else if ((this.gameObject.GetComponent<Button> () != null) 
			&& (ASMS_Data.isPlaying == false) 
			/*&& (soundManager.GetComponent<AudioSource> ().clip.name != clipToBePlayed.name)*/)
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

				PlayAudio ();

				this.gameObject.GetComponent<Image> ().overrideSprite = finalSprite;
			}
		}
	}

	public void PlayAudio()
	{
		//this.gameObject.GetComponent<AudioSourceManagerScript> ().audioSourceData.PlayOneShot (clipToBePlayed,0.5f);
		ASMS_Data.PlayOneShot (clipToBePlayed,0.5f);
	}

	public void PlaySoundOnceButtonInstantiated()
	{
		ASMS_Data.Stop ();

		PlayAudio ();
	}

	void CreateButtonAndAssignScript()
	{
		Button btn = this.gameObject.AddComponent<Button> () as Button;

		btn.GetComponent<Button>().onClick.AddListener(PlaySoundOnceButtonInstantiated); 
	}
}