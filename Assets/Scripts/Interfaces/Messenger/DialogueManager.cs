using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class DialogueManager : MonoBehaviour 
{
	public TextMeshProUGUI nameText,dialogueText;
	public GameObject messengerCanvas;
	private Queue<string> sentences;

	void Start ()
	{
		sentences = new Queue<string> ();

		if (messengerCanvas.activeSelf == true) 
		{
			messengerCanvas.SetActive (false);
			Debug.Log ("The messengerCanvas gameObject is currently active: " + messengerCanvas.activeSelf);
		} 
			
//		Button[] allChildren = messengerCanvas.GetComponentsInChildren<Button> ();
//
//		foreach (Button child in allChildren) 
//		{
//			Debug.Log("From dialogueManager: " + child.name);
//		}
	}

	public void StartDialogue(Dialogue dialogue)
	{
		Debug.Log ("Starting conversation with: " + dialogue.name);

		nameText.GetComponent<TextMeshProUGUI>().text = dialogue.name;

		sentences.Clear ();

		foreach (string sentence in dialogue.sentences) 
		{
			sentences.Enqueue (sentence);
		}

		DisplayNextSentence ();
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0) 
		{
			EndDialogue ();
			return;
		}

		string sentence = sentences.Dequeue ();

		dialogueText.GetComponent<TextMeshProUGUI>().text = sentence;

		Debug.Log (sentence);
	}

	public void EndDialogue ()
	{
			Debug.Log ("End of conversation.");
	}
}
