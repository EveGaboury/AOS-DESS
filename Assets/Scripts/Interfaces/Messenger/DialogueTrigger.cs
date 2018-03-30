using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
	public Dialogue dialogue;

	private bool conversationSwitchOn; 

	private List<GameObject> allTheObjectsInTheScene = new List<GameObject>();

	void Start()
	{
		foreach (GameObject item in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]) 
		{
			
		}
	}

	public void TriggerDialogue()
	{
		if (conversationSwitchOn == false) 
		{
			FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);

			conversationSwitchOn = !conversationSwitchOn;
		}
	}
}
