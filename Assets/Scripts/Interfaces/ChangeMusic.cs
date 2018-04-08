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

	//Private
	AudioSource audioSource;

	int currentAudioIndex = 0;

	bool isAudioPlaying;

	GameObject canvasEve;

	Color initialColor, isPlayingColor;

	void Awake()
	{
		isAudioPlaying = true;

		audioSource = GetComponent<AudioSource>();

		audioSource.Stop ();

		audioSource.clip = clipList[currentAudioIndex];

		audioSource.Play ();

		//StartCoroutine (DisplayCurrentlyPlayingSongName());
	}

	void Start() 
	{
		canvasEve = GameObject.Find ("CanvasEve");

		initialColor = Color.white;

		isPlayingColor = Color.green; 

		RetrieveAllChildrenGameObjectsOfiTunes ();

//		HighlightCurrentlyPlayingSongButton ();

		ActivateAndDeactive ();
	}

	void Update() 
	{
		CrossFadeBetweenTunes (); 

		if ((audioSource.isPlaying == true) && (audioSource.time <= .5f)) 
		{
			StartCoroutine (DisplayCurrentlyPlayingSongName());
			Debug.Log ("AudioSource is playing: " + audioSource.clip.name);
		}

		if (audioSource.time == audioSource.clip.length) 
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

		audioSource.Stop ();

		currentAudioIndex = k;

		audioSource.clip = clipList[currentAudioIndex];

		audioSource.Play ();

		//StartCoroutine (DisplayCurrentlyPlayingSongName());

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
			listeToggleChansons [i].GetComponentInChildren<TextMeshProUGUI> ().text = "<size=18>" + clipList [i].name + "</size>";
		}
	}

	void HighlightCurrentlyPlayingSongButton() 
	{
		for (int k = 0; k < listeToggleChansons.Count; k++)
		{
			if (audioSource.clip.name == clipList [k].name)
			{
				Toggle localToggle = listeToggleChansons [k].GetComponent<Toggle> ();

				ColorBlock localColorBlock = localToggle.colors;
				localColorBlock.normalColor = isPlayingColor;

				localToggle.colors = localColorBlock;

				Debug.Log ("Success! clipList[currentAudioIndex]=" + clipList [k].name);
			}  
			else
			{
				Toggle localToggle = listeToggleChansons [k].GetComponent<Toggle> ();

				ColorBlock localColorBlock = localToggle.colors;
				localColorBlock.normalColor = initialColor;

				localToggle.colors = localColorBlock;
			}
		}
	}

	IEnumerator DisplayCurrentlyPlayingSongName()
	{
		//Methode #1

		displayTitle.SetActive (true);

		displayTitle.GetComponentInChildren<TextMeshProUGUI> ().text = audioSource.clip.name;

		yield return new WaitForSeconds (5.0f);

		displayTitle.SetActive (false);

		//Methode #2
//		GameObject barreLancementRapide = GameObject.Find("Enfant_BarreGriseHaut");
//		barreLancementRapide.AddComponent<TextMeshProUGUI> ();
//		barreLancementRapide.GetComponent<TextMeshProUGUI> ().text = "<size=14>" + audioSource.clip.name + "</size>";
//		barreLancementRapide.GetComponent<Transform> ().position.x += Time.deltaTime;
//
//		float maxleft = 500.0f, initialPosition = -500.0f;
//
//		if (barreLancementRapide.GetComponent<Transform> ().position.x >= maxleft) 
//		{
//			barreLancementRapide.GetComponent<Transform> ().position.x = initialPosition;
//		}
	}

	void CrossFadeBetweenTunes ()
	{
		if (audioSource.isPlaying)
		{
			//Si la chanson est à 90% ecoulée
			if (audioSource.time >= ((audioSource.clip.length / 10) * 9)) 
			{
				if (audioSource.volume >= 0.0f) 
				{
					audioSource.volume -= Time.deltaTime;
				}
			}
			//Si la chanson est à 10% commencée
			else if (audioSource.time <= (audioSource.clip.length / 10)) 
			{
				if (audioSource.volume <= 1.0f)
				{
					audioSource.volume += Time.deltaTime;
				}
			}
		}
	}
} 