using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManagerScript : MonoBehaviour 
{
	public AudioSource audioSourceData, audioSourceBoutons, audioSourceClicksEtTyping, audioSourceCueEmotion, audioSourceMusique;

	AudioSource[] localAudioSources;

	int testINT = 0, currentMarker = 0;

	void Awake()
	{
		DetectAudioSources ();

		currentMarker = 2;
	}

	public void DetectAudioSources()
	{
		localAudioSources = this.gameObject.GetComponents<AudioSource> ();

		audioSourceData = localAudioSources [0];
		//audioSourceData.priority = 102;

		audioSourceBoutons = localAudioSources [1]; 
		//audioSourceBoutons.priority = 153;

		audioSourceClicksEtTyping = localAudioSources [2];
		//audioSourceClicksEtTyping.priority = 204 ;

		audioSourceCueEmotion = localAudioSources [3];
		//audioSourceCueEmotion.priority = 51;

		audioSourceMusique = localAudioSources [4];
		//audioSourceMusique.priority = 0;
	}

	IEnumerator WhenSoundClickScriptIsBeingCalled()
	{
		localAudioSources[0].volume = .7f;
		localAudioSources[1].volume = .7f;
		localAudioSources[3].volume = .7f;
		localAudioSources[4].volume = .7f;

		yield return new WaitForSeconds (localAudioSources[2].time);

		localAudioSources[0].volume = 1f;
		localAudioSources[1].volume = 1f;
		localAudioSources[3].volume = 1f;
		localAudioSources[4].volume = 1f;
//		for (int i = 0; i < localAudioSources.Length; i++) 
//		{
//			if (localAudioSources[i] == 2)
//			{
//				return;
//				Debug.Log ("Return has been called.");
//			} 
//			else
//			{
//				Debug.Log ("trolololo");
//			}
//		}
	}

//	void Update()
//	{
//		WhenSoundClickScriptIsBeingCalled ();
//		if (Input.GetKeyDown(KeyCode.A)) 
//		{
//			testINT += 1;
//			Debug.Log ("From AudioSourceManagerScript.cs, the current value of testINT is: " + testINT);
////			audioSourceMusique.pitch += .1f;
//		}
//
//		if (Input.GetKeyDown(KeyCode.B)) 
//		{
//			testINT -= 1;
//			Debug.Log ("From AudioSourceManagerScript.cs, the current value of testINT is: " + testINT);
////			audioSourceMusique.pitch -= .1f;
//		}
//	}0
}