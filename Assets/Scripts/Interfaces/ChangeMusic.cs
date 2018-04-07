using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using System.Linq;

[RequireComponent(typeof(AudioSource))]
public class ChangeMusic : MonoBehaviour
{
	//Public
	public AudioClip[] clipList;

	public List<GameObject> listeToggleChansons = new List<GameObject> ();

	public GameObject displayTitle;

	public Toggle testButton;

	//Private
	AudioSource audioSource;

	int currentAudioIndex = 0;

	bool isAudioPlaying;

	GameObject canvasEve;

	void Awake()
	{
		isAudioPlaying = true;

		audioSource = GetComponent<AudioSource>();

		audioSource.Stop ();

		audioSource.clip = clipList[currentAudioIndex];

		audioSource.Play ();
	}

	void Start() 
	{
		canvasEve = GameObject.Find ("CanvasEve");

		RetrieveAllChildrenGameObjectsOfiTunes ();

		ActivateAndDeactive ();
	}

	void Update() 
	{	
		Debug.Log (audioSource.clip.name + " est en train de jouer");

		HighlightCurrentlyPlayingSongButton ();

		if (audioSource.time == audioSource.clip.length) 
		{
			//Debug.Log (audioSource.clip.name + " a terminer de jouer");
			PlayNextMusic ();
		}
	}

	public void PlayMusicAtIndex(int k)
	{
		if (k >= clipList.Length && k < 0) 
		{
			return;
		}

		audioSource.Stop ();

		currentAudioIndex = k;

		audioSource.clip = clipList[currentAudioIndex];

		audioSource.Play ();
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

	public void ActivateAndDeactivateMusicInterface()
	{
		if (this.gameObject.activeSelf) 
		{
			this.gameObject.SetActive (false);
			Debug.Log (gameObject.name + " is active");
		} 
		else 
		{
			this.gameObject.SetActive (true);
			Debug.Log (gameObject.name + " is inactive");
		}
	}

	public void ActivateAndDeactive()
	{
		if (gameObject.activeSelf == true) 
		{
			gameObject.SetActive (false);
		}
		else if (gameObject.activeSelf == false) 
		{
			gameObject.SetActive (true);
		}
	}

	void RetrieveAllChildrenGameObjectsOfiTunes()
	{
		Transform[] allChildrenOfThisGameObject = GetComponentsInChildren<Transform>(true);

		foreach (Transform child in allChildrenOfThisGameObject) 
		{
			if (child.GetComponent<Toggle>() != null) 
			{
				listeToggleChansons.Add (child.gameObject);
			}
		}

		for (int i = 0; i < listeToggleChansons.Count; i++) 
		{
			listeToggleChansons [i].GetComponentInChildren<TextMeshProUGUI> ().text = "<size=18>" + clipList [i].name + "</size>" ;
		}
	}

//	IEnumerator DisplayTheNameOfCurrentlyPlayingClip()
//	{
//		GameObject instantiateDisplayer = Instantiate (displayTitle, canvasEve.transform, Quaternion.identity) as GameObject;
//
//		instantiateDisplayer.GetComponentInChildren<TMPro> ().text = audioSource.clip.name;
//
//		yield return new WaitForSeconds (5.0f);
//
//		DestroyObject (instantiateDisplayer);
//	}

	void HighlightCurrentlyPlayingSongButton()
	{
//		Toggle trololo = listeToggleChansons [currentAudioIndex].GetComponent<Toggle> ();
//
//		ColorBlock cb = trololo.colors;
//		cb.normalColor = Color.green;
//
//		trololo.colors = cb;

//		Toggle t = testButton.GetComponent<Toggle> ();
//
//		ColorBlock cb = t.colors;
//		cb.normalColor = Color.cyan;
//
//		t.colors = cb;

		//for (int k = 0; k < listeToggleChansons.Count; k++) 
		//{




//
//			if (clipList[0] == 0) 
//			{
//			print ("Success! clipList[currentAudioIndex]=" + clipList[currentAudioIndex]);
//			}
//			else if (clipList[1] == 1) 
//			{
//			print ("Success! clipList[currentAudioIndex]=" + clipList[currentAudioIndex]);
//			}
//			else if (clipList[2] == 2) 
//			{
//			print ("Success! clipList[currentAudioIndex]=" + clipList[currentAudioIndex]);
//			}
//		//}
	}
}
