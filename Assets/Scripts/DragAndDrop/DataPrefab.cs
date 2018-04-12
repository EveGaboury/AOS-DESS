using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DataPrefab : MonoBehaviour
{  
	public Sprite finalSprite;
	
	public string currentlyPlayingClip;

	public AudioClip clipToBePlayed;

	public AnimationClip animCLIP;

	public GameObject soundManager;

	[HideInInspector]
	public bool animClipIsPlaying = false, justAnotherBoool = true;

	Animator animator;

	float nextFire = 0.0f, timeIncrement = 0.0f; 

	bool isAudioClipPlaying;

	void Start()
	{
		animator = GetComponent<Animator> ();
	}

	void Update()
	{
		if (animClipIsPlaying == true) 
		{
			justAnotherBoool = false;
				
			CheckIfClipIsDonePlaying ();
		}

		if (soundManager.GetComponent<AudioSource> ().isPlaying == true/*&& (soundManager.GetComponent<AudioSource> ().clip.name == clipToBePlayed.name)*/) 
		{
			this.gameObject.GetComponent<Button> ().enabled = false; 
		} 
		else if ((this.gameObject.GetComponent<Button> () != null) && (soundManager.GetComponent<AudioSource> ().isPlaying == false))
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
		soundManager.GetComponent<AudioSource> ().Stop ();

		soundManager.GetComponent<AudioSource> ().PlayOneShot (clipToBePlayed,0.5f);
	}

	public void PlaySoundOnceButtonInstantiated()
	{
		PlayAudio ();
	}

	void CreateButtonAndAssignScript()
	{
		Button btn = this.gameObject.AddComponent<Button> () as Button;

		btn.GetComponent<Button>().onClick.AddListener(PlaySoundOnceButtonInstantiated); 
	}
}