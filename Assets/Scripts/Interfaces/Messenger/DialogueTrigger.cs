using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
	public Dialogue dialogue;

	private bool conversationSwitchOn; 

	private GameObject reference;

	private List<GameObject> allTheObjectsInTheSceneWithAButton = new List<GameObject>();

	void Start()
	{
		reference = GameObject.Find ("CanvasEve");

		Transform[] allChildren = reference.gameObject.GetComponentsInChildren<Transform> (true);

		foreach (Transform child in allChildren) 
		{
			if (child.GetComponent<Button>() && child.tag == "MarieEvePoirier") 
			{
				allTheObjectsInTheSceneWithAButton.Add (child.gameObject);

//				for (int i = 0; i < allTheObjectsInTheSceneWithAButton.Count; i++)
//				{
//					Debug.Log(allTheObjectsInTheSceneWithAButton[i].name);
//				}
			}
		}
	}

	public void TriggerDialogue()
	{
		if (conversationSwitchOn == false) 
		{
			FindObjectOfType<DialogueManager> ().StartDialogue (dialogue);

			conversationSwitchOn = !conversationSwitchOn;

			allTheObjectsInTheSceneWithAButton [0].GetComponent<Button> ().enabled = false;
		}
	}
}
