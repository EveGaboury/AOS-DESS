using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{

	public StartPosition SP;

	//public TextMeshProUGUI nameText;
	public GameObject conversationPartner, yourAnswers;
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

	//[HideInInspector]
	public bool hasConversationEnded = false;

	private Transform answerButtonsParent;

	private Dialogue dialogue;

	private ButtonDetection bttnDtct;

	private DialogueTrigger dlgTrigger;

	public scrollRectPosition SRP;
	public ForceReUpdate Force;
	public ScrollRect scrollfacebook;
	public Scrollbar scrollBarFacebook;

	public bool boulesale = false;

	float timer = 0.1f, timer2 = 0.1f, timer3 = 0.1f;

	private GameObject dialogueInstance;

	void Awake()
	{
		answerButtonsParent = SP.dialogueMessenger.GetComponent<Transform>();  
		FetchButtonsInOrderToMakeAList ();
	}

	void Start ()
	{
		sentences = new Queue<string> ();

		bttnDtct = this.gameObject.GetComponent<ButtonDetection> ();

		dlgTrigger = this.gameObject.GetComponent<DialogueTrigger> ();
	}


	public void Update()
	{
		//Debug.Log ("From DialogueManager(), the value of sentences.count is: " + sentences.Count);

		if (boulesale)
		{
			timer -= Time.deltaTime;
			if (timer <= 0f)
			{
				scrollBarFacebook.value -= 1.0f;
				Debug.Log ("allo j'existe");
				timer2 -= Time.deltaTime;
				if (timer2 <= 0f) 
				{
					boulesale = false;
					timer2 = 0.1f;
					timer = 0.1f;
				}
			}
		}
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
		Canvas.ForceUpdateCanvases ();

		if (sentences.Count == 0) 
		{
			EndDialogue ();
			Canvas.ForceUpdateCanvases ();
		}
		else if (sentences.Count > 0)
		{
			nextSentence = sentences.Dequeue (); 

			bttnDtct.WillItWorkIDontKnow ();

			prefab = conversationPartner;
			InstantiateStuff (nextSentence);

			boulesale = true;

			Canvas.ForceUpdateCanvases ();
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
		boulesale = true;
		Canvas.ForceUpdateCanvases ();

		if (prefab == conversationPartner ) 
		{
			Debug.Log ("Le prefab étant instantié est celui de MARIE-EVE");
			//Si c'est bien le prefab de conversation de marie eve, alors faire l'animation de facebook messenger des trois petits points
		}
		else if (prefab == yourAnswers) 
		{
			Debug.Log ("Le prefab étant instantié est celui de SOPHIE");
			//Si c'est bien le prefab de conversation de sophie, alors faire la coroutine TypeSentences
		}
		dialogueInstance = Instantiate (prefab, conversationHistory.position, Quaternion.identity) as GameObject;

		dialogueInstance.GetComponent<Transform> ().SetParent (conversationHistory, false);

		dialogueInstance.GetComponent<Transform> ().SetAsLastSibling ();

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

				listeNomsDeBouttons.Add (child.name);
			} 
		}
	}
}

//BOUT DE CODE POUR ANIMER LES LETTRES DANS LES BULLES DE TEXTE DU MESSENGER

//	public float writtingSpeed;
//
//	void Update()
//	{
//		if (Input.GetKeyDown(KeyCode.X))
//		{
//			string sentence = "This was a triumph!\nI'm making a note here:\nHuge success!\n\nIt's hard to overstate\nmy satisfaction.\n\nAperture Science:\nWe do what we must\nbecause we can\nFor the good of all of us.\nExcept the ones who are dead.\n\nBut there's no sense crying\nover every mistake.\nYou just keep on trying\n'til you run out of cake.\nAnd the science gets done.\nAnd you make a neat gun\nfor the people who are\nstill alive.\n\nI'm not even angry...\nI'm being so sincere right now.\nEven though you broke my heart,\nand killed me.\n\nAnd tore me to pieces.\nAnd threw every piece into a fire.\nAs they burned it hurt because\nI was so happy for you!\n\nNow, these points of data\nmake a beautiful line.\nAnd we're out of beta.\nWe're releasing on time!\nSo I'm GLaD I got burned!\nThink of all the things we learned!\nfor the people who are\nstill alive.\n\nGo ahead and leave me...\nI think I'd prefer to stay inside...\nMaybe you'll find someone else\nto help you.\nMaybe Black Mesa?\nThat was a joke. Ha Ha. Fat Chance!\n\nAnyway this cake is great!\nIt's so delicious and moist!\n\nLook at me: still talking\nwhen there's science to do!\nWhen I look out there,\nit makes me glad I'm not you.\n\nI've experiments to run.\nThere is research to be done.\nOn the people who are\nstill alive.\nAnd believe me I am\nstill alive.\nI'm doing science and I'm\nstill alive.\nI feel fantastic and I'm\nstill alive.\nWhile you're dying I'll be\nstill alive.\nAnd when you're dead I will be\nstill alive\n\nStill alive.\n\nStill alive.";
//			StartCoroutine (TypeSentence(sentence));
//		}
//	}
//
//	IEnumerator TypeSentence(string sentence)
//	{
//		//this.gameObject.GetComponent<TextMeshProUGUI> ().text = "";
//
//		foreach (char letter in sentence.ToCharArray())
//		{
//			dialogueInstance.GetComponentInChildren<TextMeshProUGUI> ().text+= letter;
//			yield return new WaitForSeconds (writtingSpeed);
//		}
//	}