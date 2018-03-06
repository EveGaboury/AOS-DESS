using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonManager: MonoBehaviour {


	public StartPosition SP;

	//game state
	public GameObject sessionCass;
	public bool SoOpen = true;


	//boutton corbeille
	public Button bouttontrash;
	public GameObject windowCass;
	public GameObject windowSo; 

	//bouton Browser
	public Button boutonRougeBrowser;

	//GameObject affecté par les bouttons
	public GameObject facebookHeader;
	public GameObject browserCanvas;
	public GameObject facebookCanvas;


	//inputfield et boutton pour facebook mot de passe
	public Button inputfieldWrongButton;
	public TMP_InputField inputfieldWrongText;
	private string reponsecorrecte = "cassandraroyer@courriel.fr", reponsecorrecte2 = "Cassandraroyer@courriel.fr" ; 

	public GameObject faux;
	public Image bouttonWrongPass;

	public Sprite vrai;
	public Sprite pasvrai;
	public TMP_InputField inputfieldQuestion1;




	void Start () 
	{

		Button btn = bouttontrash.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClickTrash);

		boutonRougeBrowser.GetComponent <Button> ();
		boutonRougeBrowser.onClick.AddListener (TaskonClickBoutonRouge);

		Button btnn = inputfieldWrongButton.GetComponent<Button> ();
		btnn.onClick.AddListener (TaskOnClickForgotFacebook);


		SpriteRenderer initial = GetComponent<SpriteRenderer> ();

		TextMeshPro inputfieldQuestion1 = GetComponent <TextMeshPro> ();

	
	}



	void Update () 
	{
		//game state
		if (sessionCass.activeSelf == true) {
			SoOpen = false;
		}
		else{
			SoOpen = true;
		}
	}

	void TaskOnClickTrash () 
	{
		if (SoOpen) 
		{
			windowSo.SetActive (true);
		} else {
			windowCass.SetActive (true);
		}
	}

	void TaskonClickBoutonRouge () 
	{
		facebookHeader.SetActive (false);
		browserCanvas.SetActive (false);
		facebookCanvas.SetActive (false);
	}
		
	 void TaskOnClickForgotFacebook ()
	{
		if ((reponsecorrecte == inputfieldWrongText.text) || (reponsecorrecte2 == inputfieldWrongText.text)) {
			SP.questionOne.SetActive (true);
			bouttonWrongPass.sprite = vrai;
		} else {
			faux.SetActive (true);
			bouttonWrongPass.sprite = pasvrai;
		}
	}

	public void ClearContent (){

		inputfieldWrongText.text = "";
		inputfieldQuestion1.text = "";

		}
}
