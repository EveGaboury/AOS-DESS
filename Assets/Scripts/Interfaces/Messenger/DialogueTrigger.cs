using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
	public Dialogue dialogue;

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);
	}

	void Update()
	{
		if (Input.GetKeyUp(KeyCode.A)) 
		{
			TriggerDialogue();
//			Debug.Log ("TriggerDialogue();");
		}
	}
}
