using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueTrigger : MonoBehaviour
{
	public Dialogue dialogue;

	[HideInInspector]
	public bool conversationSwitchOn = false; 

	[HideInInspector]
	public List<GameObject> allTheObjectsInTheSceneWithAButton = new List<GameObject>();

	private GameObject reference;

	private DialogueManager dlgManager;

	private ButtonDetection bttDetection;

	void Start()
	{
		reference = GameObject.Find ("CanvasEve");

		dlgManager = this.gameObject.GetComponent<DialogueManager> ();

		bttDetection = this.gameObject.GetComponent<ButtonDetection> ();

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

			allTheObjectsInTheSceneWithAButton [0].GetComponent<Button> ().enabled = false;
			allTheObjectsInTheSceneWithAButton [0].GetComponent<Button> ().interactable = false;
		}
	}
}
