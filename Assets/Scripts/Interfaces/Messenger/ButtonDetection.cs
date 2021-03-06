﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class ButtonDetection : MonoBehaviour/*, IPointerClickHandler*/
{
	[TextArea(3,10)]
	public string[] reponsesSophieQ1, reponsesSophieQ2, reponseMarieEveASophieQ1,reponseMarieEveASophieQ2;

	[HideInInspector]
	public bool answerTheQuestion = false;

	//[HideInInspector]
	public bool[] whatCouldGoWrong = new bool[] {false, false};

	private GameObject messengerManager;

	private string[] oneTwoThreeViveLAlgerie = new string[] {"Alpha1","Alpha2","Alpha3"};

	private Color currentColor, highlitedColor, normalColor;

	private KeyCode currentKey;

	private string currentValueOfSophieAnswer;

	private float minimumTime = 5.0f;
	   
	private int currentIndex;

	void Start ()
	{
		messengerManager = GameObject.Find ("DialogueManager");

		highlitedColor = Color.red; 

		normalColor = Color.white;
	}

	void Update()
	{
		ActivateAndDeactivateAnswerButtons ();

		RegulateSomeShit ();
	} 

	void ActivateAndDeactivateAnswerButtons()
	{
		for (int l = 0; l < this.gameObject.GetComponent<DialogueManager>().listeDeBouttons.Count; l++) 
		{
			if (this.gameObject.GetComponent<DialogueTrigger>().conversationSwitchOn == false) 
			{
				this.gameObject.GetComponent<DialogueManager> ().listeDeBouttons [l].gameObject.GetComponent<Button> ().enabled = false;
			}
			else if(this.gameObject.GetComponent<DialogueTrigger>().conversationSwitchOn == true)
			{
				this.gameObject.GetComponent<DialogueManager> ().listeDeBouttons [l].gameObject.GetComponent<Button> ().enabled = true;
			}
		}
	}

	void ManageButtonColor() 
	{
		for (int k = 0; k < 3; k++)
		{
			if (currentKey.ToString () == oneTwoThreeViveLAlgerie [k].ToString ()) 
			{
				if (messengerManager.GetComponent<DialogueManager> ().hasConversationEnded == false)
				{
					messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [k].gameObject.GetComponent<Image> ().color = currentColor;
				}
				else if(messengerManager.GetComponent<DialogueManager> ().hasConversationEnded == true)
				{
					messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [k].gameObject.GetComponent<Image> ().color = normalColor;
				}
			}
		}
	}

	void RegulateSomeShit()
	{
		if (this.gameObject.GetComponent<DialogueTrigger>().conversationSwitchOn == true) 
		{
			for (int i = 0; i < messengerManager.GetComponent<DialogueManager> ().listeDeBouttons.Count; i++) 
			{
				if (messengerManager.GetComponent<DialogueManager> ().sentences.Count == 0) 
				{
					messengerManager.GetComponent<DialogueManager> ().EndDialogue ();
				}
				else if (messengerManager.GetComponent<DialogueManager> ().sentences.Count == 1) 
				{
					messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [i].GetComponentInChildren<TextMeshProUGUI> ().text = reponsesSophieQ2 [i];
				}
				else if (messengerManager.GetComponent<DialogueManager> ().sentences.Count == 2) 
				{
					messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [i].GetComponentInChildren<TextMeshProUGUI> ().text = reponsesSophieQ1 [i];
				}
			}
		}
	}

	public void WillItWorkIDontKnow()    
	{
		if (messengerManager.GetComponent<DialogueManager> ().sentences.Count == 0) 
		{
			for (int i = 0; i < 3; i++)
			{
				if ((EventSystem.current.currentSelectedGameObject == this.gameObject.GetComponent<DialogueManager>().listeDeBouttons[i]) || (currentKey.ToString() == oneTwoThreeViveLAlgerie[i]))
				{
					currentIndex = i;

					//SOPHIE
					InstantiateSophieAnswers(reponsesSophieQ2[currentIndex]);

					//MARIE EVE
					InstantiateMarieEveAnswers(reponseMarieEveASophieQ2[currentIndex]);
				}
			}
		}
		else if (messengerManager.GetComponent<DialogueManager> ().sentences.Count == 1) 
		{
			for (int j = 0; j < 3; j++) 
			{
				if ((EventSystem.current.currentSelectedGameObject == this.gameObject.GetComponent<DialogueManager>().listeDeBouttons[j]) || (currentKey.ToString() == oneTwoThreeViveLAlgerie[j]))
				{
					currentIndex = j;

					//SOPHIE
					InstantiateSophieAnswers(reponsesSophieQ1 [currentIndex]);

					//MARIE EVE
					InstantiateMarieEveAnswers(reponseMarieEveASophieQ1 [currentIndex]);
				}
			}
		}
	}

	void InstantiateSophieAnswers(string answerSophie)
	{
		messengerManager.GetComponent<DialogueManager> ().prefab = messengerManager.GetComponent<DialogueManager> ().yourAnswers;

		messengerManager.GetComponent<DialogueManager> ().InstantiateStuff (answerSophie);

		//StartCoroutine (TypeSentence(answerSophie));
	}

	void InstantiateMarieEveAnswers(string answerMarieEve)
	{
		messengerManager.GetComponent<DialogueManager> ().prefab = messengerManager.GetComponent<DialogueManager> ().conversationPartner;

		messengerManager.GetComponent<DialogueManager> ().InstantiateStuff (answerMarieEve);

		//StartCoroutine (TypeSentence(answerMarieEve));
	}

	IEnumerator TypeSentence(string sentence)
	{
		foreach (char letter in sentence.ToCharArray())
		{
			this.gameObject.GetComponent<DialogueManager>().dialogueInstance.GetComponentInChildren<TextMeshProUGUI> ().text += letter;
			//dialogueInstance.GetComponentInChildren<TextMeshProUGUI> ().text += letter;
			yield return new WaitForSeconds (.05f);
		}
	}
}