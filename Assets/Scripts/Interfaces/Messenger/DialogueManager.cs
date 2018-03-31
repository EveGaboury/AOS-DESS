using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{
	public TextMeshProUGUI nameText/*, dialogueText*/;
	public GameObject messengerCanvas, partnerHistory, yourHistory;
	public Transform conversationHistory;

	[HideInInspector]
	public Queue<string> sentences;

	[HideInInspector]
	public List<GameObject> listeDeBouttons = new List<GameObject>();

	[HideInInspector]
	public List<string> listeDePhrases = new List<string>(), listeNomsDeBouttons = new List<string>();

	[HideInInspector]
	public string nextSentence;

	[HideInInspector]
	public GameObject prefab;

	private Dialogue dialogue;

	private Transform answerButtonsParent;

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

		SetNameOfButtonsTHREE ();
	}

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

		nextSentence = sentences.Dequeue ();

//		Debug.Log (nextSentence);

//		dialogueText.GetComponent<TextMeshProUGUI>().text = nextSentence;

		prefab = partnerHistory;
		InstantiateStuff(nextSentence);
	}

	public void EndDialogue ()
	{
		for (int i = 0; i < listeDeBouttons.Count; i++) 
		{
			if (listeDeBouttons[i].name == "ContinueConversation") 
			{
				listeDeBouttons [i].GetComponentInChildren<TextMeshProUGUI> ().text = "End of conversation.";
//				Debug.Log ("End of conversation.");
			}
		}
	}		

	public void PickAButton()
	{
		DisplayNextSentence ();
//		prefab = yourHistory;
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
			if (child.GetComponent<Button>() != null && child.tag == "AnswerButton") 
			{	
				listeDeBouttons.Add (child.gameObject);
				listeNomsDeBouttons.Add (child.name);
			} 
		}
//		for (int i = 0; i < 4; i++) 
//		{
//			Debug.Log (/*"listeDeBouttons: " + listeDeBouttons.Count + "\n" + "listeNomsDeBouttons: " + listeNomsDeBouttons.Count*/
//				"listeDeBouttons: " + listeDeBouttons[i].name + "\n" + "listeNomsDeBouttons: " + listeNomsDeBouttons[i]);
//		}
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

	public void SetNameOfButtonsTHREE()
	{
		for (int i = 0; i < listeDeBouttons.Count; i++) 
		{
			if (listeDeBouttons[i].gameObject.name == listeNomsDeBouttons[i]) 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = listeNomsDeBouttons[i] + " Q1";
			}
		}
	}

	public void SetNameOfButtonsTWO()
	{
		for (int i = 1; i < listeDeBouttons.Count; i++) 
		{
			if (listeDeBouttons[i].gameObject.name == "Answer01") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer01 , Q02";
			}
			if (listeDeBouttons[i].gameObject.name == "Answer02") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer02, Q02";
			}
			if (listeDeBouttons[i].gameObject.name == "Answer03") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer03 , Q02";
			}
		}
	}

	public void SetNameOfButtonsONE()
	{
		for (int i = 1; i < listeDeBouttons.Count; i++) 
		{
			if (listeDeBouttons[i].gameObject.name == "Answer01") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer01 , Q03";
			}
			if (listeDeBouttons[i].gameObject.name == "Answer02") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer02, Q03";
			}
			if (listeDeBouttons[i].gameObject.name == "Answer03") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer03 , Q03";
			}
		}
	}

	public void SetNameOfButtonsZERO()
	{
		for (int i = 1; i < listeDeBouttons.Count; i++) 
		{
			if (listeDeBouttons[i].gameObject.name == "Answer01") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer01 , Q04";
			}
			if (listeDeBouttons[i].gameObject.name == "Answer02") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer02, Q04";
			}
			if (listeDeBouttons[i].gameObject.name == "Answer03") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer03 , Q04";
			}
		}
	}
}