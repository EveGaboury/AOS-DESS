using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
	public Dialogue dialogue;

	[HideInInspector]
	public bool conversationSwitchOn = false; 

	private GameObject reference;

	[HideInInspector]
	public List<GameObject> allTheObjectsInTheSceneWithAButton = new List<GameObject>();

	void Start()
	{
		reference = GameObject.Find ("CanvasEve");

		Transform[] allChildren = reference.gameObject.GetComponentsInChildren<Transform> (true);

		foreach (Transform child in allChildren) 
		{
			if (child.GetComponent<Button>() && child.tag == "MarieEvePoirier") 
			{
				allTheObjectsInTheSceneWithAButton.Add (child.gameObject);
			}
		}
	}

	public void TriggerDialogue()
	{
		if (conversationSwitchOn == false) 
		{
			conversationSwitchOn = true;

			FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);

//			Destroy (allTheObjectsInTheSceneWithAButton [0].GetComponent<Button> ());

			allTheObjectsInTheSceneWithAButton [0].GetComponent<Button> ().enabled = false;
			allTheObjectsInTheSceneWithAButton [0].GetComponent<Button> ().interactable = false;

//			conversationSwitchOn = false;
		}
	}
}
