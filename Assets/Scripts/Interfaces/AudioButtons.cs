using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioButtons : MonoBehaviour 
{
	//Public
	public AudioClip tocButtonSound;

	public List<GameObject> childObjectsContainingButtons = new List<GameObject>();

	public GameObject targetObject, data;

	//Private
	AudioClip currentAudioCLip;

	float lowPitchRange = 0.9f, highPitchRange = 1.05f;

	AudioSourceManagerScript ASMS_buttons;

	void Start()
	{
		ASMS_buttons = this.gameObject.GetComponent<AudioSourceManagerScript> ();

		SearchAllButtonsInTheHierarchy ();
		RetrieveChildrenOfData ();
		SearchForGameObjectsWithToggleComponents ();

		AddSoundToButton ();

		targetObject = GameObject.Find ("CanvasEve");
		data = GameObject.Find ("Data");
	}

	void SearchAllButtonsInTheHierarchy()
	{
		Transform[] allChildren = targetObject.GetComponentsInChildren<Transform> (true);

		foreach (Transform child in allChildren) 
		{
			if (child.gameObject.GetComponent<Button> ()) 
			{
				childObjectsContainingButtons.Add (child.gameObject);
				child.gameObject.AddComponent<CursorScript> ();
			}
		}
	}

	void RetrieveChildrenOfData()
	{
		Transform[] sweetSummerChild = data.GetComponentsInChildren<Transform> (true);

		foreach (Transform children in sweetSummerChild)
		{
			if (children.gameObject.GetComponent<DataPrefab> () == true)
			{
				children.gameObject.AddComponent<CursorScript> ();
			}
		}
	}

	void SearchForGameObjectsWithToggleComponents()
	{
		Transform[] toggleSons = targetObject.GetComponentsInChildren<Transform> (true);

		foreach (Transform sons in toggleSons)
		{
			if (sons.gameObject.GetComponent<Toggle> () == true)
			{
				sons.gameObject.AddComponent<CursorScript> ();
			}
		}
	}

	void DetermineButtonSoundToBePlayed()
	{
		float randomPitch = Random.Range (lowPitchRange, highPitchRange);

		ASMS_buttons.audioSourceBoutons.pitch = randomPitch;
		ASMS_buttons.audioSourceBoutons.PlayOneShot (tocButtonSound, 1.0f);
	}

	void AddSoundToButton()
	{
		for (int j = 0; j < childObjectsContainingButtons.Count; j++)
		{
			childObjectsContainingButtons [j].GetComponent<Button> ().onClick.AddListener (DetermineButtonSoundToBePlayed);
		}
	}
}