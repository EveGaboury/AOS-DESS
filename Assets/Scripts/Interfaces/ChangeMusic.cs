using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class ChangeMusic : MonoBehaviour
{	
	public AudioClip[] clipList;

	AudioSource audioSource;
	int currentArrayIndex = 0;
	bool isAudioPlaying;

	void Start()
	{
		isAudioPlaying = true;

		audioSource = GetComponent<AudioSource>();

		audioSource.Stop ();

		audioSource.clip = clipList[0];

		audioSource.Play ();
	}

	void Update()
	{
		Debug.Log ("Currently playing: " + audioSource.clip.name);
		ChooseNew ();
	}

	void ChooseNew()
	{
		for (int i = 0; i < clipList.Length; i++) 
		{
			if (audioSource.time == clipList[i].length)
			{	
				currentArrayIndex = i;
				//Debug.Log("currently playing: ");
			}
//			else if (clipList[i] == clipList[2]) 
//			{
//				Debug.Log ("je suis arriver a la fin de la liste");
//			}

		}
		currentArrayIndex = (currentArrayIndex + 1) % clipList.Length;

		audioSource.PlayOneShot (clipList[currentArrayIndex]);


		Debug.Log ("this is: " + clipList[currentArrayIndex]);
	}

	public void NextTune()
	{
		audioSource.Stop ();
		//
		Debug.Log ("play the NEXT tune in the list");
	}

	public void PreviousTune ()
	{
		audioSource.Stop ();

		Debug.Log ("play the PREVIOUS tune in the list");
	}

	public void PlayThatFunkyMusicWhiteBoy()
	{
		if (isAudioPlaying == true) 
		{
			audioSource.Pause ();
		}
		else if(isAudioPlaying == false)
		{
			audioSource.UnPause ();
		}

		isAudioPlaying = !isAudioPlaying;

		Debug.Log ("Calcul en cours...");
	}
}
