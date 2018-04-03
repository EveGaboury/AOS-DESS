using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class ButtonDetection : MonoBehaviour/*, IPointerClickHandler*/
{
	[TextArea(3,10)]
	public string[] reponsesSophieQ1, reponsesSophieQ2, reponseMarieEveASophieQ1;

	[HideInInspector]
	public bool answerTheQuestion = false;

	//[HideInInspector]
	public bool[] whatCouldGoWrong = new bool[] {false, false};

	private GameObject messengerManager;

	private string[] oneTwoThreeViveLAlgerie = new string[] {"Alpha1","Alpha2","Alpha3"};

	private Color currentColor, highlitedColor, normalColor;

	private KeyCode currentKey;

	private string currentQuestion;

	private float minimumTime = .3f;
	    
	void Start ()
	{
		messengerManager = GameObject.Find ("DialogueManager");

		highlitedColor = Color.red; 

		normalColor = Color.white;
	}

	void Update()
	{
		CheckIfKeyWasPressed ();

		ActivateAndDeactivateAnswerButtons ();

		WillItWorkIDontKnow ();
	} 

	public void CheckWhatQuestionIsCurrentlyDisplayed() 
	{
		if (messengerManager.GetComponent<DialogueManager>().sentences.Count == 0) 
		{
//			DetectPlayerAnswers ();
			messengerManager.GetComponent<DialogueManager> ().EndDialogue ();
//			Debug.Log ("From ButtonDetedtion(): " + messengerManager.GetComponent<DialogueTrigger>().dialogue.sentences[j]);
		}
		else if (messengerManager.GetComponent<DialogueManager>().sentences.Count  == 1) 
		{
			whatCouldGoWrong [0] = true;

			currentQuestion = "Q2";
			RegulateSomeShit ();

			//whatCouldGoWrong [0] = false;

		}
		else if (messengerManager.GetComponent<DialogueManager>().sentences.Count  == 2)
		{
			whatCouldGoWrong [1] = true;

			currentQuestion = "Q1";
			RegulateSomeShit ();

			//whatCouldGoWrong [1] = false;
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

				for (int j = 0; j < messengerManager.GetComponent<DialogueManager> ().listeDeBouttons.Count; j++) 
				{
					if (pressedKey.ToString() == oneTwoThreeViveLAlgerie[j])
					{
						messengerManager.GetComponent<DialogueManager> ().DisplayNextSentence ();

						if (pressedKey.ToString() == oneTwoThreeViveLAlgerie[0])
						{
							Debug.Log ("From ButtonDetection() && CheckIfKeyWasPressed(): \n"
								+ messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [j].name 
								+ " sentences.Count:"+
								+ messengerManager.GetComponent<DialogueManager>().sentences.Count);
						}
						if (pressedKey.ToString() == oneTwoThreeViveLAlgerie[1])
						{
							Debug.Log ("From ButtonDetection() && CheckIfKeyWasPressed(): \n"
								+ messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [j].name 
								+ " sentences.Count:"+
								+ messengerManager.GetComponent<DialogueManager>().sentences.Count);
						}
						if (pressedKey.ToString() == oneTwoThreeViveLAlgerie[2])
						{
							Debug.Log ("From ButtonDetection() && CheckIfKeyWasPressed(): \n"
								+ messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [j].name 
								+ " sentences.Count:"+
								+ messengerManager.GetComponent<DialogueManager>().sentences.Count);
						}
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

	public void DetectPlayerAnswers() 
	{
		for (int i = 0; i < messengerManager.GetComponent<DialogueManager> ().listeDeBouttons.Count; i++)
		{
			if (EventSystem.current.currentSelectedGameObject.gameObject.name == messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [i].name)
			{
				if (EventSystem.current.currentSelectedGameObject.name == "Answer01") 
				{
					Debug.Log ("From ButtonDetection() && DetectPlayerAnswers(): \n"
						+ messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [i].name 
						+ " sentences.Count:"+
						+ messengerManager.GetComponent<DialogueManager>().sentences.Count);
				}
				if (EventSystem.current.currentSelectedGameObject.name == "Answer02") 
				{
					Debug.Log ("From ButtonDetection() && DetectPlayerAnswers():: \n" 
						+ messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [i].name 
						+ " sentences.Count:"+
						+ messengerManager.GetComponent<DialogueManager>().sentences.Count);
				}
				if (EventSystem.current.currentSelectedGameObject.name == "Answer03")
				{
					Debug.Log ("From ButtonDetection() && DetectPlayerAnswers(): \n"
						+ messengerManager.GetComponent<DialogueManager> ().listeDeBouttons [i].name 
						+ " sentences.Count:"+
						+ messengerManager.GetComponent<DialogueManager>().sentences.Count);
				}
			}
		}
	}

	void RegulateSomeShit()
	{
		messengerManager.GetComponent<DialogueManager> ().currentMarkerOfQuestions = currentQuestion;

		messengerManager.GetComponent<DialogueManager> ().UpdateNameOfButtons ();
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

	public void WillItWorkIDontKnow()    
	{
		messengerManager.GetComponent<DialogueManager>().prefab = messengerManager.GetComponent<DialogueManager>().yourAnswers;

		bool localBool = true;

		if (messengerManager.GetComponent<DialogueManager>().sentences.Count == 1) 
		{
			if ( whatCouldGoWrong[0] == true) 
			{
				if (localBool == true)
				{
					if (EventSystem.current.currentSelectedGameObject.name == "Answer01" || currentKey.ToString() == oneTwoThreeViveLAlgerie[0])
					{
						messengerManager.GetComponent<DialogueManager>().InstantiateStuff(reponsesSophieQ1 [0]) ;
						localBool = false;
					}
					if (EventSystem.current.currentSelectedGameObject.name == "Answer02" || currentKey.ToString() == oneTwoThreeViveLAlgerie[1])
					{
						messengerManager.GetComponent<DialogueManager>().InstantiateStuff(reponsesSophieQ1 [1]);
						localBool = false;
					}
					if (EventSystem.current.currentSelectedGameObject.name == "Answer03" || currentKey.ToString() == oneTwoThreeViveLAlgerie[2])
					{
						messengerManager.GetComponent<DialogueManager>().InstantiateStuff(reponsesSophieQ1 [2]);
						localBool = false;
					}
				}
				localBool = false;
			}
		}

		if (messengerManager.GetComponent<DialogueManager>().sentences.Count == 2)
		{
			if (whatCouldGoWrong[1] == true)  
			{
				if (localBool == true)
				{
					if (EventSystem.current.currentSelectedGameObject.name == "Answer01" || currentKey.ToString() == oneTwoThreeViveLAlgerie[0])
					{
						messengerManager.GetComponent<DialogueManager>().InstantiateStuff(reponsesSophieQ1 [0]);
						localBool = false;
					}
					if (EventSystem.current.currentSelectedGameObject.name == "Answer02" || currentKey.ToString() == oneTwoThreeViveLAlgerie[1])
					{
						messengerManager.GetComponent<DialogueManager>().InstantiateStuff(reponsesSophieQ1 [1]);
						localBool = false;
					}
					if (EventSystem.current.currentSelectedGameObject.name == "Answer03" || currentKey.ToString() == oneTwoThreeViveLAlgerie[2])
					{
						messengerManager.GetComponent<DialogueManager>().InstantiateStuff(reponsesSophieQ1 [2]);
						localBool = false;
					}
					localBool = false;
				}
			}
		}
	}

//	IEnumerator ChangeBoolValues() 
//	{
//		whatCouldGoWrong [1] = true;
//
//		yield return new WaitForSeconds (1.0f);
//
//		whatCouldGoWrong [1] = false;
//	}
}