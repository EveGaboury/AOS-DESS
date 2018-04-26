using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueTrigger : MonoBehaviour
{
	public Dialogue dialogue;

	//[HideInInspector]
	public bool conversationSwitchOn = false; 

	[HideInInspector]
	public List<GameObject> allTheObjectsInTheSceneWithAButton = new List<GameObject>();

	private GameObject reference;

	private DialogueManager dlgManager;

	private ButtonDetection bttDetection;

	public Scrollbar scrollfacebook;

	bool activateConversation = false;

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
		if (conversationSwitchOn == false && activateConversation == false)
		{
			conversationSwitchOn = true;
			activateConversation = true;

			this.gameObject.GetComponent<DialogueManager> ().prefab = this.gameObject.GetComponent<DialogueManager> ().conversationPartner;
			this.gameObject.GetComponent<DialogueManager>().StartDialogue (dialogue);

			//FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);		
		}
	}
}
