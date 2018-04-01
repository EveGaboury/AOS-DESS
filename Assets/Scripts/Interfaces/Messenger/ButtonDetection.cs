using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ButtonDetection : MonoBehaviour/*, IPointerClickHandler*/
{
	private GameObject messengerManager;

	private string[] oneTwoThreeViveLAlgerie = new string[] {"Alpha1","Alpha2","Alpha3"};

	private Color currentColor, highlitedColor, normalColor;

	KeyCode currentKey;

	[HideInInspector]
	public bool answerTheQuestion = false;

	private string currentQuestion;

	void Start ()
	{
		messengerManager = GameObject.Find ("DialogueManager");

		highlitedColor = Color.red;

		normalColor = Color.white;
	}

	void Update()
	{
		CheckIfKeyWasPressed ();
		if (this.gameObject.GetComponent<DialogueTrigger>().conversationSwitchOn == true) 
		{
			CheckWhatQuestionIsCurrentlyDisplayed ();
		}

	}

	public void CheckWhatQuestionIsCurrentlyDisplayed() 
	{
		for (int j = 0; j < messengerManager.GetComponent<DialogueManager>().listeDePhrases.Count; j++) 
		{
			if (messengerManager.GetComponent<DialogueManager>().sentences.Count  == 1) 
			{
				messengerManager.GetComponent<DialogueManager> ().EndDialogue ();
			}
			else if (messengerManager.GetComponent<DialogueManager>().sentences.Count == 2) 
			{
				currentQuestion = "Q4";
				RegulateSomeShit ();

//				Debug.Log ("From ButtonDetedtion(): " + messengerManager.GetComponent<DialogueTrigger>().dialogue.sentences[j]);
			}
			else if (messengerManager.GetComponent<DialogueManager>().sentences.Count  == 3) 
			{
				currentQuestion = "Q3";
				RegulateSomeShit ();

//				Debug.Log ("From ButtonDetedtion(): " + messengerManager.GetComponent<DialogueTrigger>().dialogue.sentences[j]);
			}
			else if (messengerManager.GetComponent<DialogueManager>().sentences.Count  == 4) 
			{
				answerTheQuestion = true;
				currentQuestion = "Q2";
				RegulateSomeShit (); 
				answerTheQuestion = false;
//				Debug.Log ("From ButtonDetedtion(): " + messengerManager.GetComponent<DialogueTrigger>().dialogue.sentences[j]);
			}
		}
	}


	void CheckIfKeyWasPressed()
	{
		foreach (KeyCode pressedKey in System.Enum.GetValues(typeof(KeyCode))) 
		{
			if (Input.GetKeyDown(pressedKey))
			{
				currentKey = pressedKey;
				currentColor = highlitedColor;
				ManageButtonColor ();

				for (int i = 0; i < oneTwoThreeViveLAlgerie.Length; i++) 
				{
					if (pressedKey.ToString() == oneTwoThreeViveLAlgerie[i])
					{
						messengerManager.GetComponent<DialogueManager> ().DisplayNextSentence ();
						CheckWhatQuestionIsCurrentlyDisplayed ();
					}
				}
			}
			else if (Input.GetKeyUp(pressedKey))
			{
				currentKey = pressedKey;
				currentColor = normalColor;
				ManageButtonColor ();
			}
		}
	}

	void ManageButtonColor() 
	{
		for (int i = 0; i < 3; i++) 
		{
			if (currentKey.ToString () == oneTwoThreeViveLAlgerie [i].ToString ()) 
			{
				messengerManager.GetComponent<DialogueManager>().listeDeBouttons[i].gameObject.GetComponent<Image> ().color = currentColor;
			}
		}
	}

	void RegulateSomeShit()
	{
		//answerTheQuestion = true;

		messengerManager.GetComponent<DialogueManager> ().currentMarkerOfQuestions = currentQuestion;

		messengerManager.GetComponent<DialogueManager> ().UpdateNameOfButtons ();

		//answerTheQuestion = false;
	}
}