using System.Collections.Generic;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ChangeMusic : MonoBehaviour
{
	//Public
	public AudioClip[] clipList, cueEmotion;

	public GameObject displayTitle, iTunes;

	//Private
	List<GameObject> listeNomsChansons = new List<GameObject> ();

	int currentAudioIndex = 0;

	bool isAudioPlaying;

	GameObject canvasEve;

	Color initialColor, isPlayingColor;

	AudioSourceManagerScript ASMS_Music;

	void Awake()
	{
		ASMS_Music = this.gameObject.GetComponent<AudioSourceManagerScript> ();

		RetrieveAllChildrenGameObjectsOfiTunes ();
	}

	void Start() 
	{
		ASMS_Music.audioSourceMusique.Stop ();

		ASMS_Music.audioSourceMusique.clip = clipList[currentAudioIndex];

		ASMS_Music.audioSourceMusique.Play ();

		isAudioPlaying = true;

		canvasEve = GameObject.Find ("CanvasEve");

		initialColor = Color.white;

		isPlayingColor = Color.green; 

		HighlightCurrentlyPlayingSongButton ();
	}

	void Update() 
	{
		//CrossFadeBetweenTunes (); 

		if (ASMS_Music.audioSourceMusique.isPlaying == true && ASMS_Music.audioSourceMusique.time <= .5f) 
		{
			StartCoroutine (DisplayCurrentlyPlayingSongName());
		}

		if (ASMS_Music.audioSourceMusique.time == ASMS_Music.audioSourceMusique.clip.length) 
		{
			PlayNextMusic ();
		}
	}

	public void PlayMusicAtIndex(int k)
	{
		if (k >= clipList.Length && k < 0) 
		{
			return;
		}

		ASMS_Music.audioSourceMusique.Stop ();

		currentAudioIndex = k;

		ASMS_Music.audioSourceMusique.clip = clipList[currentAudioIndex];

		ASMS_Music.audioSourceMusique.Play ();

		HighlightCurrentlyPlayingSongButton ();
	}

	public void PlayNextMusic()
	{
		int k = (currentAudioIndex + 1) % clipList.Length;

		PlayMusicAtIndex(k);
	}

	public void PlayPreviousMusic()
	{
		int k = (currentAudioIndex - 1) % clipList.Length;

		if (k <= 0) 
		{
			k = 0;
		}

		PlayMusicAtIndex(k);
	}

	void HighlightCurrentlyPlayingSongButton() 
	{
		for (int k = 0; k < listeNomsChansons.Count; k++)
		{
			if (ASMS_Music.audioSourceMusique.clip.name == clipList [k].name)
			{
				listeNomsChansons [k].GetComponent<Image> ().color = isPlayingColor;
			}  
			else
			{
				listeNomsChansons [k].GetComponent<Image> ().color = initialColor;
			}
		}
	}

	IEnumerator DisplayCurrentlyPlayingSongName()
	{
		displayTitle.SetActive (true);

		displayTitle.GetComponentInChildren<TextMeshProUGUI> ().text = ASMS_Music.audioSourceMusique.clip.name;

		yield return new WaitForSeconds (5.0f);

		displayTitle.SetActive (false);
	}

	void RetrieveAllChildrenGameObjectsOfiTunes()
	{
		Transform[] allChildrenOfThisGameObject = iTunes.gameObject.GetComponentsInChildren<Transform>(true);

		foreach (Transform child in allChildrenOfThisGameObject) 
		{
			if (child.GetComponent<Image>() != null && child.name.Contains("Button_")) 
			{
				listeNomsChansons.Add (child.gameObject);
			}
		}

		for (int i = 0; i < listeNomsChansons.Count; i++) 
		{
			listeNomsChansons [i].GetComponentInChildren<TextMeshProUGUI> ().text = "<size=18>" + clipList [i].name + "</size>";
		}
	}

	void CrossFadeBetweenTunes ()
	{
		if (ASMS_Music.audioSourceMusique.isPlaying)
		{
			//Si la chanson est à 10% de la fin
			if (ASMS_Music.audioSourceMusique.time >= ((ASMS_Music.audioSourceMusique.clip.length / 10) * 9)) 
			{
				if (ASMS_Music.audioSourceMusique.volume >= 0.0f) 
				{
					ASMS_Music.audioSourceMusique.volume -= Time.deltaTime;
				}
			}
			//Si la chanson est à 10% commencée
			else if (ASMS_Music.audioSourceMusique.time <= (ASMS_Music.audioSourceMusique.clip.length / 10)) 
			{
				if (ASMS_Music.audioSourceMusique.volume <= 1.0f)
				{
					ASMS_Music.audioSourceMusique.volume += Time.deltaTime;
				}
			}
		}
	}
}



//	public void RandomizeNextSong()
//	{
//		//Do the thingy!
//	}
//
//	public void FadeInFadeOutCueEmotion()
//	{
//		for (int j = 0; j < clipList.Length; j++)
//		{
//			if (clipList[j] && audioSource1.isPlaying == true) 
//			{
//				/*audioSource1.volume = .5f;*/
//
//				/*audioSource2.PlayOneShot(cueEmotion [j]);*/
//					
//				int j = [j];
//				StartCoroutine(FadeCueEmotion(j));
//
//				/*audioSource1.volume = 1.0f;*/
//			}
//		}
//	}

//	IEnumerator FadeCueEmotion(int j)
//	{
//     	audioSource1.volume = .5f;
//		audioSource2.PlayOneShot(cueEmotion [j]);
//		yield return new WaitForSeconds (5.0f);
//		audioSource1.volume = 1.0f;
//	}

//	void CrossFadeBetweenTunes ()
//	{
//		if (audioSource1.isPlaying)
//		{
//			//Si la chanson est à 10% de la fin
//			if (audioSource1.time >= ((audioSource1.clip.length / 10) * 9)) 
//			{
//				if (audioSource1.volume >= 0.0f) 
//				{
//					audioSource1.volume -= Time.deltaTime;
//				}
//			}
//			//Si la chanson est à 10% commencée
//			else if (audioSource1.time <= (audioSource.clip.length / 10)) 
//			{
//				if (audioSource1.volume <= 1.0f)
//				{
//					audioSource1.volume += Time.deltaTime;
//				}
//			}
//		}
//	}