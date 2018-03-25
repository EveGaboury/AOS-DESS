﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPrefab : MonoBehaviour 
{
	public string currentlyPlayingClip;

	public AudioClip clipToBePlayed;

	public AnimationClip animCLIP;

	public GameObject canvas;

	Animator animator;

	[HideInInspector]
	public bool animClipIsPlaying = false, justAnotherBoool = true;

	void Start()
	{
		animator = GetComponent<Animator> ();
	}

	void Update()
	{
		if (animClipIsPlaying == true) 
		{
			justAnotherBoool = false;
			CheckIfClipIsPlaying ();
		}
	}

	void CheckIfClipIsPlaying()
	{
		if (animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName (currentlyPlayingClip) &&
			animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1.0f) 
		{
			animClipIsPlaying = false;

			animator.SetBool ("onClick", false);

			if (animClipIsPlaying == false && justAnotherBoool == false) 
			{
				PlayAudio ();
				CreateButtonAndAssignScript ();
			}
		}
	}

	public void PlayAudio()
	{
		canvas.GetComponent<AudioSource> ().PlayOneShot (clipToBePlayed,0.5f);
	}

	public void PlaySoundOnceButtonInstantiated()
	{
		canvas.GetComponent<AudioSource> ().Stop ();
		PlayAudio ();
		Debug.Log(name + " has been clicked.");
	}

	void CreateButtonAndAssignScript()
	{
		Button btn = this.gameObject.AddComponent<Button> ();
		btn.onClick.AddListener(PlaySoundOnceButtonInstantiated);
	}
}