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

	Animator animator;

	[HideInInspector]
	public bool animClipIsPlaying = false, justAnotherBoool = true;

	//Pablo, il va falloir regler le play writting sound qui n'existe pas...
//	void Start()
//	{
//		animator = GetComponent<Animator> ();
//
//		this.gameObject.GetComponent<Button> ().onClick.AddListener (Playwrittingsound) ;
//	}

	void Update()
	{
		if (animClipIsPlaying == true) 
		{
			justAnotherBoool = false;
				
			CheckIfClipIsDonePlaying ();
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
				PlayAudio ();
				CreateButtonAndAssignScript ();
				this.gameObject.GetComponent<Image> ().overrideSprite = finalSprite;
			}
		}
	}
		
	public void PlayAudio()
	{
		soundManager.GetComponent<AudioSource> ().PlayOneShot (clipToBePlayed,0.5f);
	}


	public void PlaySoundOnceButtonInstantiated()
	{
		soundManager.GetComponent<AudioSource> ().Stop ();
		PlayAudio ();
		Debug.Log(name + " has been clicked.");
	}

	void CreateButtonAndAssignScript()
	{
		Button btn = this.gameObject.AddComponent<Button> () as Button;

		btn.GetComponent<Button>().onClick.AddListener(PlaySoundOnceButtonInstantiated);
	}
}