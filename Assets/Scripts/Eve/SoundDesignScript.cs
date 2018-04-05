using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundDesignScript : MonoBehaviour 
{

	//list sound mouse clikcs and typing
	public AudioClip[] soundClickList;
	public AudioClip[] soundtypingList;

	//AudioSource pou les sound Design sounds
	public AudioSource audioSourceSD;

	//AudioClip Sound Courriel Application
	public AudioClip sound_courriel;

	//AudioClip Sound Trash Application
	public AudioClip sound_trash;

	//AudioClip Sound Browser Application
	public AudioClip sound_browser;

	//AudioClip Sound Itunes Application
	public AudioClip sound_itunes;






	//public ButtonManager BM;



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




	public void OnclickSoundCourriel () 
	{
		audioSourceSD.clip = sound_courriel;
		audioSourceSD.PlayOneShot (audioSourceSD.clip);
	}

	public void OnclickSoundTrash () 

	{
		audioSourceSD.clip = sound_trash;
		audioSourceSD.PlayOneShot (audioSourceSD.clip);

	}

	public void OnclickSoundBrowser () 

	{
		audioSourceSD.clip = sound_browser;
		audioSourceSD.PlayOneShot (audioSourceSD.clip);

	}

	public void OnclickSoundItunes () 

	{
		audioSourceSD.clip = sound_itunes;
		audioSourceSD.PlayOneShot (audioSourceSD.clip);

	}




}

	//Debug.Log(System.Enum.GetValues(typeof(KeyCode)));