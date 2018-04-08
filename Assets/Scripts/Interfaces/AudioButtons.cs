using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioButtons : MonoBehaviour 
{
	public AudioClip[] audioClipByInterface;

	public List<GameObject> childObjectsContainingButtons = new List<GameObject>(), parentObjects = new List<GameObject>();

	string gmailCanvas = "GmailCanvas 1"
	, deskTopCanvas = "DesktopCanvas"
	, messengerCanvas = "MessengerCanvas"
	, facebookCanvas = "FacebookCanvas"
	, browserCanvas = "BrowserCanvas"
	, startMessengerConversation = "StartMessengerConversation";

	AudioSource soundPlayer;

	AudioClip currentAudioCLip;

	float lowPitchRange = 0.9f, highPitchRange = 1.05f;

	void Start()
	{
		soundPlayer = this.gameObject.GetComponent<AudioSource> ();

		SearchAllButtonsInTheHierarchy ();
		SortButtonsByParent ();
	}

	void SearchAllButtonsInTheHierarchy()
	{
		Transform[] allChildren = GetComponentsInChildren<Transform> (true);

		foreach (Transform child in allChildren) 
		{
			if (child.gameObject.GetComponent<Button> ()) 
			{
				childObjectsContainingButtons.Add (child.gameObject);
			} 
			else 
			{
				parentObjects.Add (child.gameObject);
			}
		}
	}

	void SortButtonsByParent()
	{
		for (int i = 0; i < parentObjects.Count; i++)
		{
			if (parentObjects[i].gameObject.name == gmailCanvas) 
			{
				if (parentObjects[i].gameObject.GetComponentsInChildren<Transform>(true) != null) 
				{
					for (int j = 0; j < childObjectsContainingButtons.Count; j++) 
					{
						if (childObjectsContainingButtons[j].gameObject != null) 
						{
							childObjectsContainingButtons [j].gameObject.tag = "Gmail";

//							currentAudioCLip = audioClipByInterface[0];
							DetermineButtonSoundToBePlayed ();
						}
					}
				}
			}
		}
	}

	void DetermineButtonSoundToBePlayed()
	{
		float randomPitch = Random.Range (lowPitchRange, highPitchRange);

		soundPlayer.pitch = randomPitch;
		soundPlayer.PlayOneShot (currentAudioCLip, 1.0f);
	}
}