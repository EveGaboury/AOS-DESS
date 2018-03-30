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
	private Dialogue dialogue;

	[HideInInspector]
	public GameObject prefab;

	[HideInInspector]
	public List<GameObject> listeDeBouttons = new List<GameObject>();

	[HideInInspector]
	public List<string> listeDePhrases = new List<string>();

	[HideInInspector]
	public string test, nextSentence;

	void Awake()
	{
		if (messengerCanvas.activeSelf == true) 
		{
			messengerCanvas.SetActive (false);
		}
	}

	void Start ()
	{
		sentences = new Queue<string> ();

		FetchButtonsInOrderToMakeAList ();

		SetNameOfButtonsTHREE ();
	}

	public void StartDialogue(Dialogue dialogue)
	{
//		Debug.Log ("Starting conversation with: " + dialogue.name);

		nameText.GetComponent<TextMeshProUGUI>().text = dialogue.name;

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
				Debug.Log ("End of conversation.");
			}
		}
	}		

	public void PickAButton()
	{
//		Debug.Log (test);
		DisplayNextSentence ();
//		prefab = yourHistory;
//		InstantiateStuff(test);
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
		Transform[] allChildren = messengerCanvas.GetComponentsInChildren<Transform> ();

		foreach (Transform child in allChildren) 
		{
			if (child.GetComponent<Button>() != null) 
			{	
				listeDeBouttons.Add (child.gameObject);
			} 
		}
	}

	public void ActivateAndDeactivateMessengerCanvas()
	{
		if (messengerCanvas.activeSelf == true) 
		{
			messengerCanvas.SetActive (false);
			Debug.Log (messengerCanvas.name + " is active: False");
		} 
		else if(messengerCanvas.activeSelf == false)
		{
			messengerCanvas.SetActive (true);
//			Debug.Log (messengerCanvas.name + " is active: True");
		}
	}

	public void SetNameOfButtonsTHREE()
	{
		for (int i = 1; i < listeDeBouttons.Count; i++) 
		{
			if (listeDeBouttons[i].gameObject.name == "Answer01") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer01 , Q01";
			}
			if (listeDeBouttons[i].gameObject.name == "Answer02") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer02, Q01";
			}
			if (listeDeBouttons[i].gameObject.name == "Answer03") 
			{
				listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI>().text = "Answer03 , Q01";
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