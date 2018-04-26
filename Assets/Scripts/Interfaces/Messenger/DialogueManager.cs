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
	public scrollRectPosition SRP;
	public ForceReUpdate Force;
	public ScrollRect scrollfacebook;
	public Scrollbar scrollBarFacebook;
	public bool boulesale = false;

	public AudioClip messengerSFX;

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

	private float timer = 0.1f, timer2 = 0.1f, timer3 = 0.1f;

	private GameObject dialogueInstance;

	public AudioSourceManagerScript ASMS;

	public Image boutonME;

	public Sprite boutonME_Sprite;

	float writtingSpeed = 0.03f;

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
				//Debug.Log ("allo j'existe");
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

			//prefab = conversationPartner; 
			InstantiateStuff (nextSentence);

			boulesale = true;

			Canvas.ForceUpdateCanvases ();
		}
	}

	public void EndDialogue ()
	{
		boutonME.GetComponent<Image>().sprite = boutonME_Sprite;

		hasConversationEnded = true;

		listeDeBouttons [0].gameObject.transform.parent.gameObject.SetActive (false);
	}	 

	public void InstantiateStuff(string dialogue)
	{
		boulesale = true;
		Canvas.ForceUpdateCanvases ();

		if (prefab == conversationPartner ) 
		{
			dialogueInstance = Instantiate (prefab, conversationHistory.position, Quaternion.identity) as GameObject;

			dialogueInstance.GetComponent<Transform> ().SetParent (conversationHistory, false);

			dialogueInstance.GetComponent<Transform> ().SetAsLastSibling ();

			dialogueInstance.GetComponent<Transform> ().localScale = new Vector2 (prefab.GetComponent<Transform>().localScale.x, prefab.GetComponent<Transform>().localScale.y);

			//StartCoroutine (TypeSentence(dialogue));

			dialogueInstance.GetComponentInChildren<TextMeshProUGUI> ().text = dialogue;

			//ASMS.GetComponent<AudioSourceManagerScript>().audioSourceClicksEtTyping.PlayOneShot (messengerSFX);
			Debug.Log ("Le prefab étant instantié est celui de MARIE-EVE; varialble dialogue= " + dialogue);
			//Si c'est bien le prefab de conversation de marie eve, alors faire l'animation de facebook messenger des trois petits points
		}
		else if (prefab == yourAnswers) 
		{
			dialogueInstance = Instantiate (prefab, conversationHistory.position, Quaternion.identity) as GameObject;

			dialogueInstance.GetComponent<Transform> ().SetParent (conversationHistory, false);

			dialogueInstance.GetComponent<Transform> ().SetAsLastSibling ();

			dialogueInstance.GetComponent<Transform> ().localScale = new Vector2 (prefab.GetComponent<Transform>().localScale.x, prefab.GetComponent<Transform>().localScale.y);

			dialogueInstance.GetComponentInChildren<TextMeshProUGUI> ().text = dialogue;

//			StartCoroutine (TypeSentence(dialogue));

			Debug.Log ("Le prefab étant instantié est celui de SOPHIE; varialble dialogue= " + dialogue);
			//Si c'est bien le prefab de conversation de sophie, alors faire la coroutine TypeSentences
		}
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

	IEnumerator TypeSentence(string sentence)
	{
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueInstance.GetComponentInChildren<TextMeshProUGUI> ().text += letter;
			yield return new WaitForSeconds (.05f);
		}
	}
}