using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class Test : MonoBehaviour
{
	public string currentlyPlayingClip;

	public AudioClip clipToBePlayed;

	public AnimationClip animCLIP;

	public GameObject canvas;

	Animator animator;

	[HideInInspector]
	public bool animClipIsPlaying = false, justAnotherBoool = false;

	void Start()
	{
		animator = GetComponent<Animator> ();
	}

	public void StartAnimation()
	{
//		animator.SetTrigger ("Click");
		animator.SetBool ("onClick", true);
		justAnotherBoool = true;
//		CheckIfClipIsPlaying ();
//		animClipIsPlaying = true;
	}

	void Update()
	{
		if (justAnotherBoool == true) 
		{
			CheckIfClipIsPlaying ();
		}

//		float timeRemainingInAnim = animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime;
//		Debug.Log (timeRemainingInAnim);
//
//		if (timeRemainingInAnim = 2.3f) 
//		{
//			Debug.Log ("Yay!");	
//		}
//		Debug.Log (animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime);

//		Debug.Log("Test.cs: " + animator.GetBool ("onClick"));


//		if (clipHasEnded == true) 
//		{
//			PlayAudio ();
//			canvas.GetComponent<AudioSource> ().PlayOneShot (clipToBePlayed,0.5f);
		//		})
//		if (Mathf.Approximately(animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime, animCLIP.length) )
//		{
//			Debug.Log ("Smeagol is free!");
//		}
	}

	void CheckIfClipIsPlaying()
	{
		if (animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName (currentlyPlayingClip) &&
			animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1.0f) 
		{
//			animator.SetTrigger ("Click");
			Debug.Log ("Smeagol is free!");
			justAnotherBoool = false;
			animator.SetBool ("onClick", false);

			if (animator.GetBool("onClick") == false && justAnotherBoool == false) 
			{
				PlayAudio ();
			}

			//if (animClipIsPlaying == true) 
			//{
			//	PlayAudio ();
			//}

		}
//		if (animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName (currentlyPlayingClip) &&
//		    animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime >= 1.0f) 
//		{
//			animator.SetBool ("onClick", false);
//			clipHasEnded = true;
//			Debug.Log ("C'est la que le son va se declcenhcer");
//		}
//		else 
//		{	
//			clipHasEnded = false;
//		}
	}



	public void PlayAudio()
	{
//		canvas.GetComponent<AudioSource> ().Stop ();

		canvas.GetComponent<AudioSource> ().PlayOneShot (clipToBePlayed,0.5f);

//		if (canvas.GetComponent<AudioSource> ().time == canvas.GetComponent<AudioSource> ().clip.length) 
//		{
//			animClipIsPlaying = false;
//		}
	}

	public void StopAudio()
	{
		canvas.GetComponent<AudioSource> ().Stop ();
	}
} 