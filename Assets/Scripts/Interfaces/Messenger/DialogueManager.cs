using System.Collections;
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
	public string nextSentence, currentMarkerOfQuestions;

	[HideInInspector]
	public GameObject prefab;

	private Transform answerButtonsParent;

	private Dialogue dialogue;

	void Awake()
	{
		if (messengerCanvas.activeSelf == true) 
		{
			messengerCanvas.SetActive (false);
		}
	}

	void Start ()
	{
		answerButtonsParent = messengerCanvas.GetComponent<Transform>().Find ("Conversation"); 

		sentences = new Queue<string> ();

		FetchButtonsInOrderToMakeAList ();

		currentMarkerOfQuestions = "Q1";
		UpdateNameOfButtons ();
	}

//	void Update()
//	{
//		if (Input.GetKeyUp(KeyCode.Y)) 
//		{
//			DisplayNextSentence ();
//			Debug.Log (sentences.Count);
//
//			for (int i = 0; i < listeDeBouttons.Count; i++) 
//			{
//				Debug.Log ("From DialogueManager(): " + listeDeBouttons[i].name);
//			}
//
//			Debug.Log ("The EndDialogue () method has been called.");
//			EndDialogue ();
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
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0) 
		{
			EndDialogue ();
			return;
		} 
		else if (sentences.Count > 0) 
		{
			nextSentence = sentences.Dequeue (); 

			prefab = conversationPartner;
			InstantiateStuff(nextSentence);
		}
		

		//if (this.gameObject.GetComponent<ButtonDetection>().answerTheQuestion == true) 
		//{
			prefab = yourAnswers;
			InstantiateStuff(nextSentence + " test");
		//}
	}

	public void EndDialogue ()
	{
		for (int i = 0; i < listeDeBouttons.Count; i++) 
		{
			if (listeDeBouttons[i].gameObject != null) 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "<size=16>End of conversation.</size>";

				listeDeBouttons [i].GetComponent<Button> ().enabled = false;

				Debug.Log ("End of conversation.");
			}
		}
	}	 

	void InstantiateStuff(string dialogue)
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
			if (listeDeBouttons[i].gameObject.name == listeNomsDeBouttons[i]) 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = listeNomsDeBouttons[i] + " " + currentMarkerOfQuestions;
			}
		}
	}
}