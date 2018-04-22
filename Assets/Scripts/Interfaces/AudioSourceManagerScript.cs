using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManagerScript : MonoBehaviour 
{
	public AudioSource audioSourceData, audioSourceBoutons, audioSourceClicksEtTyping, audioSourceCueEmotion, audioSourceMusique;

	AudioSource[] localAudioSources;

	void Awake()
	{
		DetectAudioSources ();
	}

	public void DetectAudioSources()
	{
		localAudioSources = this.gameObject.GetComponents<AudioSource> ();

		audioSourceData = localAudioSources [0];

		audioSourceBoutons = localAudioSources [1]; 

		audioSourceClicksEtTyping = localAudioSources [2];

		audioSourceCueEmotion = localAudioSources [3];

		audioSourceMusique = localAudioSources [4];
	}

//	void Update()
//	{
//		if (Input.GetKey(KeyCode.A)) 
//		{
//			//audioSourceData.GetComponent<AudioSource>().enabled = false;
//			//localAudioSources [0].enabled = false;
//			//Debug.Log ("The Alpha1 key has been pressed.");
//		}
////		else if (Input.GetKeyUp(KeyCode.Alpha1))
////		{
////			localAudioSources [0].enabled = true;
////		}
//
//
//		if (Input.GetKey(KeyCode.Z)) 
//		{
//			localAudioSources [1].enabled = false;
//			//Debug.Log ("The Alpha2 key has been pressed.");
//		}
////		else if (Input.GetKeyUp(KeyCode.Alpha2))
////		{
////			localAudioSources [1].enabled = true;
////		}
//
//
//		if (Input.GetKey(KeyCode.E)) 
//		{
//			localAudioSources [2].enabled = false;
//			//Debug.Log ("The Alpha3 key has been pressed.");
//		}
////		else if (Input.GetKeyUp(KeyCode.Alpha3))
////		{
////			localAudioSources [2].enabled = true;
////		}
//
//
//		if (Input.GetKey(KeyCode.R)) 
//		{
//			localAudioSources [3].enabled = false;
//			//Debug.Log ("The Alpha4 key has been pressed.");
//		}
////		else if (Input.GetKeyUp(KeyCode.Alpha4))
////		{
////			localAudioSources [3].enabled = true;
////		}
//
//
//		if (Input.GetKey(KeyCode.T)) 
//		{
//			localAudioSources [4].enabled = false;
//			//Debug.Log ("The Alpha5 key has been pressed.");
//		}
////		else if (Input.GetKeyUp(KeyCode.Alpha5))
////		{
////			localAudioSources [4].enabled = true;
////		}
//	}
}