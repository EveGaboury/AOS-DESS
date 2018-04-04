using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundDesignScript : MonoBehaviour 
{
	public AudioClip[] soundClickList;
	public AudioClip[] soundtypingList;

	public AudioSource audioSourceSD;

	void Awake ()
	{
		audioSourceSD = this.gameObject.GetComponent<AudioSource> ();
	}
		

	void Update () 
	{
		if (Input.GetMouseButtonDown (0))
		{
			audioSourceSD.clip = soundClickList [Random.Range (0,soundClickList.Length)];
			audioSourceSD.PlayOneShot (audioSourceSD.clip);
			Debug.Log ("son de mouse");

		}
			
		if (Input.anyKeyDown)
		{
			if (Input.GetMouseButton (0) || Input.GetMouseButton (1) || Input.GetMouseButton (2) )
			{
				return;
			}
				audioSourceSD.clip = soundtypingList [Random.Range (0,soundtypingList.Length)];
				audioSourceSD.PlayOneShot (audioSourceSD.clip);
				Debug.Log ("son de clavier");
		}
	}
}

	//Debug.Log(System.Enum.GetValues(typeof(KeyCode)));