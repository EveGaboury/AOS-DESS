﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{
	public TextMeshProUGUI nameText;
	public GameObject messengerCanvas, conversationPartner, yourAnswers;
	public Transform conversationHistory;

	[HideInInspector]
	public Queue<string> sentences;

	[HideInInspector]
	public List<GameObject> listeDeBouttons = new List<GameObject>();

	[HideInInspector]
	public List<string> listeDePhrases = new List<string>(), listeNomsDeBouttons = new List<string>();

	[HideInInspector]
	public string nextSentence, currentMarkerOfQuestions, currentTextValueOfButton;

	[HideInInspector]
	public GameObject prefab;

	[HideInInspector]
	public bool hasConversationEnded = false;

	private Transform answerButtonsParent;

	private Dialogue dialogue;

	void Awake()
	{
		answerButtonsParent = messengerCanvas.GetComponent<Transform>().Find ("Conversation");  

		FetchButtonsInOrderToMakeAList ();

		if (messengerCanvas.activeSelf == true) 
		{
			messengerCanvas.SetActive (false);
		}
	}

	void Start ()
	{
		sentences = new Queue<string> ();

		currentMarkerOfQuestions = "Q1";
	}

//	void Update()
//	{
//		if (sentences.Count == 0) 
//		{
//			for (int i = 0; i < this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong.Length; i++) 
//			{
//				this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [2] = false;
//			}
//		}
//		else if (sentences.Count == 1) 
//		{
//			this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [1] = true;
//
//			this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [1] = false;
//			this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [0] = false;
//			this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [2] = false;
//		}
//		else if (sentences.Count == 2) 
//		{
//			this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [2] = true;
//
//			this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [2] = false;
//			this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [0] = false;
//			this.gameObject.GetComponent<ButtonDetection> ().whatCouldGoWrong [1] = false;
//		}
//	}

	public void StartDialogue(Dialogue dialogue)
	{ 
		sentences.Clear ();

		foreach (string sentence in dialogue.sentences) 
		{
			sentences.Enqueue (sentence);
			listeDePhrases.Add (sentence);
		}

		DisplayNextSentence ();
		UpdateNameOfButtons ();
	}

	public void DisplayNextSentence () 
	{
		if (sentences.Count > 0) 
		{
			nextSentence = sentences.Dequeue (); 

			prefab = conversationPartner;
			InstantiateStuff(nextSentence);
			this.gameObject.GetComponent<ButtonDetection> ().CheckWhatQuestionIsCurrentlyDisplayed ();
		}
	}

	public void EndDialogue ()
	{
		hasConversationEnded = true;

		for (int i = 0; i < listeDeBouttons.Count; i++) 
		{
			if (listeDeBouttons[i].gameObject != null) 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "<size=14>Fin de la conversation.</size>";

				listeDeBouttons [i].GetComponent<Button> ().enabled = false;

				Debug.Log ("End of conversation.");
			}
		}
	}	 

	public void InstantiateStuff(string dialogue)
	{
		GameObject dialogueInstance = Instantiate (prefab, conversationHistory.position, Quaternion.identity) as GameObject;

		dialogueInstance.GetComponent<Transform> ().SetParent (conversationHistory);

		dialogueInstance.GetComponent<Transform> ().localScale = new Vector2 (prefab.GetComponent<Transform>().localScale.x, prefab.GetComponent<Transform>().localScale.y);

		dialogueInstance.GetComponentInChildren<TextMeshProUGUI> ().text = dialogue;
	}

 	void FetchButtonsInOrderToMakeAList() 
	{
		Transform[] allChildren = answerButtonsParent.GetComponentsInChildren<Transform> ();

		foreach (Transform child in allChildren) 
		{
			if (child.gameObject.GetComponent<Button> () != null && child.gameObject.tag == "AnswerButton")
			{	
				listeDeBouttons.Add (child.gameObject);

//				for (int i = 0; i < listeDeBouttons.Count; i++)
//				{
//					Debug.Log ("From DialogueManager(), the current value of allChildren is: "+ listeDeBouttons[i].name);
//				} 
//
				listeNomsDeBouttons.Add (child.name);
			} 
		}
	}

	public void ActivateAndDeactivateMessengerCanvas()
	{
		if (messengerCanvas.activeSelf == true) 
		{
			messengerCanvas.SetActive (false);
		} 
		else if(messengerCanvas.activeSelf == false)
		{
			messengerCanvas.SetActive (true);
		}
	}

	public void UpdateNameOfButtons()
	{
		for (int i = 0; i < listeDeBouttons.Count; i++) 
		{
			currentTextValueOfButton = listeNomsDeBouttons [i] + " " + currentMarkerOfQuestions; 

			if (listeDeBouttons[i].gameObject.name == listeNomsDeBouttons[i]) 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = currentTextValueOfButton;  
			}
		}
	}
}