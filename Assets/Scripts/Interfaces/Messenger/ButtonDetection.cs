﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ButtonDetection : MonoBehaviour, IPointerClickHandler
{
	public Color newCoolor;

	[HideInInspector]
	public string bttnName;

	[HideInInspector]
	public int bttnID;

	public DialogueManager dialogueManager;

	int currentIndex = 0;

	void Awake()
	{
		bttnName = name;
		bttnID = transform.GetInstanceID ();
	}

	void Start()
	{
		ColorBlock colorBlock = transform.GetComponent<Button>().colors;
		colorBlock.highlightedColor = newCoolor;	
		transform.GetComponent<Button>().colors = colorBlock;
	}

	public void OnPointerClick(PointerEventData pointerEventData)
	{
		if ((pointerEventData.button == PointerEventData.InputButton.Left) || (pointerEventData.button == PointerEventData.InputButton.Right)) 
		{
//			dialogueManager.GetComponent<DialogueManager> ().test = "This is the name of the button that has been clicked: " + bttnName + "\n"+ "This is the ID of the button that has been clicked: "+ bttnID.ToString();
//			dialogueManager.GetComponent<DialogueManager> ().test = dialogueManager.GetComponent<DialogueManager> ().HelloWorld("test");
//			Debug.Log (bttnName + " Game Object Clicked!" + bttnID);
		}
	}

	public void CheckWhatQuestionIsCurrentlyDisplayed(/*int k*/)
	{
		DialogueManager dlg = dialogueManager.GetComponent<DialogueManager> ();

//		Debug.Log ("test: "+ dlg.sentences.Count);

		for (int i = 0; i < dlg.listeDePhrases.Count; i++) 
		{
			if (dlg.sentences.Count == 0) 
			{
				dlg.SetNameOfButtonsZERO ();

				if (dlg.listeDeBouttons[i].name == this.gameObject.name) 
				{
					dlg.prefab = dlg.yourHistory;
					dlg.InstantiateStuff (name + "Q04");
					Debug.Log ("Boutton a ete presse: " + name);
				}


				Debug.Log ("Phrases restanates: " + dlg.sentences.Count);
			}
			else if (dlg.sentences.Count == 1) 
			{
				dlg.SetNameOfButtonsONE ();

				if (dlg.listeDeBouttons[i].name == this.gameObject.name) 
				{
					dlg.prefab = dlg.yourHistory;
					dlg.InstantiateStuff (name + "Q03");
					Debug.Log ("Boutton a ete presse: " + name);
				}

				Debug.Log ("Phrases restanates: " +  dlg.sentences.Count);
			}
			else if (dlg.sentences.Count == 2) 
			{
				dlg.SetNameOfButtonsTWO ();

				if (dlg.listeDeBouttons[i].name == this.gameObject.name) 
				{
					dlg.prefab = dlg.yourHistory;
					dlg.InstantiateStuff (name + "Q02");
					Debug.Log ("Boutton a ete presse: " + name);
				}
					
				Debug.Log ("Phrases restanates: " + dlg.sentences.Count);
			}
			else if (dlg.sentences.Count == 3) 
			{
				dlg.SetNameOfButtonsTHREE ();

				if (dlg.listeDeBouttons[i].name == this.gameObject.name) 
				{
					dlg.prefab = dlg.yourHistory;
					dlg.InstantiateStuff (name + "Q01");
					Debug.Log ("Boutton a ete presse: " + name);
				}

				Debug.Log (this.gameObject.name);
//				Debug.Log ("test: "+ dlg.sentences.Count);
			}

			//			Debug.Log (dlg.listeDePhrases.IndexOf(dlg.listeDePhrases[i]));

			//			if (dlg.listeDePhrases.IndexOf(dlg.listeDePhrases[0]) == 0) 
			//			{
			//				Debug.Log (dlg.sentences.Count);
			//				Debug.Log (dlg.listeDePhrases[0]);
			//			}
		}


//		Debug.Log (dlg.listeDePhrases.IndexOf("question 1"));
		//k = 1;

		//currentIndex = k;

//		Debug.Log (dlg.listeDePhrases.Count);


		//if (k >= dlg.listeDePhrases.Count && k < 0)
//		{
			//return;
//		}


//		for (int i = 1; i < (dlg.listeDePhrases.Count + 1); i++) 
//		{

//			Debug.Log (dlg.nextSentence);

//			if (dlg.listeDePhrases[i] == /*dlg.sentences.Contains(dlg.sentences[i])*/dialogueManager.GetComponent<DialogueManager> ().nextSentence) 
//			{
//				Debug.Log ("From ButtonDetection(): " + dialogueManager.GetComponent<DialogueManager> ().nextSentence);
//			}

//			if (dlg.listeDePhrases[i] == dialogueManager.GetComponent<DialogueManager> ().nextSentence) 
//			{
//				Debug.Log ("From ButtonDetection(): " + dlg.listeDePhrases[i]);
//
//				dlg.listeDeBouttons[i].GetComponentInChildren<TextMeshProUGUI> ().text = "Answer0" + i + " , Q0" +i;
//
//				foreach (GameObject bttn in dlg.listeDeBouttons) 
//				{
//					bttn.GetComponentInChildren<TextMeshProUGUI> ().text = "test"/*"Answer0" + i + " , Q0" +i*/;
//					//				sentences.Enqueue (sentence);
//				}
//			}
//		}
			
//		for (int i = 0; i < dlg.listeDePhrases.Count; i++)
//		{
//			if (dlg.listeDePhrases [i] == dialogueManager.GetComponent<DialogueManager> ().nextSentence) 
//			{
//				this.gameObject.GetComponentInChildren<TextMeshProUGUI> ().text = "Answer0" + i + " , Q0" + i;
//				Debug.Log ("success: " + name);
//			}

//			if (dlg.listeDeBouttons[i] == this.gameObject) 
//			{
//				this.gameObject.GetComponentInChildren<TextMeshProUGUI> ().text = "Answer0" + i + " , Q0" + i;
//				Debug.Log ("success: " + name);
//			}

//			if (dlg.listeDeBouttons[i] == this.gameObject) 
//			{		
//				foreach (GameObject item in dlg.listeDeBouttons) 
//				{
//					if (item.name == "Asnwer01") 
//					{
//						Debug.Log(item.name);
//					}
//
//					item.text = "Answer0" + i + " , Q0" + i;
//				}
//			}
//			Debug.Log ("The next sentence to be displayed is: " + dialogueManager.GetComponent<DialogueManager> ().nextSentence);
//		}
	}
}