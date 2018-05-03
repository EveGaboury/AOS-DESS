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

	bool isAudioClipPlaying;

	AudioSourceManagerScript ASMS_Data;

	GameObject localGameObject, scriptManager;

	void Start()
	{
		animator = GetComponent<Animator> ();

		localGameObject = GameObject.Find ("SoundManager");

		scriptManager = GameObject.Find ("ScriptManager");

		ASMS_Data = localGameObject.gameObject.GetComponent<AudioSourceManagerScript> ();
	}

	void FixedUpdate()
	{
		if (animClipIsPlaying == true) 
		{
			justAnotherBoool = false;

			CheckIfClipIsDonePlaying ();
		}

		if ((this.gameObject.GetComponent<Button> () != null) && (ASMS_Data.audioSourceData.isPlaying == true)) 
		{
			this.gameObject.GetComponent<Button> ().enabled = false; 
		} 
		else if ((this.gameObject.GetComponent<Button> () != null) && (ASMS_Data.audioSourceData.isPlaying == false))
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

				AudioSource[] localArrayAudioSources = new AudioSource[] {/*ASMS_Data.audioSourceMusique,*/ ASMS_Data.audioSourceBoutons, ASMS_Data.audioSourceClicksEtTyping/*, ASMS_Data.audioSourceCueEmotion*/};

				for (int i = 0; i < localArrayAudioSources.Length; i++)
				{
					ASMS_Data.GetComponent<AudioSourceManagerScript> ().StopAllCoroutines ();

					ASMS_Data.audioSourceData.volume = 1.0f;

					StartCoroutine (localGameObject.GetComponent<AudioSourceManagerScript> ().PlayAudio (localArrayAudioSources, clipToBePlayed, ASMS_Data.audioSourceData));
				}

				this.gameObject.GetComponent<Image> ().overrideSprite = finalSprite;
			}
		}
	}

	public void PlaySoundOnceButtonInstantiated()
	{
		ASMS_Data.audioSourceData.Stop ();

		AudioSource[] localArrayAudioSources = new AudioSource[] {/*ASMS_Data.audioSourceMusique,*/ ASMS_Data.audioSourceBoutons, ASMS_Data.audioSourceClicksEtTyping/*, ASMS_Data.audioSourceCueEmotion*/};

		//for (int i = 0; i < localArrayAudioSources.Length; i++)
		//{
			ASMS_Data.GetComponent<AudioSourceManagerScript> ().StopAllCoroutines ();

			//InvokeRepeating("Test", 0.0f, 0.3f);

			ASMS_Data.audioSourceData.volume = 1.0f;

			StartCoroutine (localGameObject.GetComponent<AudioSourceManagerScript> ().PlayAudio (localArrayAudioSources, clipToBePlayed, ASMS_Data.audioSourceData));
		//}
	}

	void CreateButtonAndAssignScript()
	{
		Button btn = this.gameObject.AddComponent<Button> () as Button;

		btn.GetComponent<Button>().onClick.AddListener(PlaySoundOnceButtonInstantiated); 
	}

//	void Test()
//	{
////		for (int k = 0; k < 20; k++)
////		{
////			ASMS_Data.audioSourceData.volume += 0.05f;
////		}
//		ASMS_Data.audioSourceData.volume = 1.0f;
//	}
}