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

	//facebook state
	public GameObject ButtonSophie;
	public bool soOpenFacebook = false;

	public GameObject NFSo;
	public Button iconFb;

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
	public Button wrongButton;
	public Image wrongImage;
	public TMP_InputField inputfieldWrongText;
	private string reponsecorrecte = "cassandraroyer@courriel.fr", reponsecorrecte2 = "Cassandraroyer@courriel.fr" ; 


	public Sprite vrai;
	public Sprite pasvrai;
	public Sprite initial;


	public Button question1Button;
	public Image question1Image;
	public TMP_InputField inputfieldQuestionOne;
	private string reponseQuestion1 = "Zeus", reponseQuestion1a = "zeus"; 

	private string clear ="";


	void Start () 
	{

		Button btn = bouttontrash.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClickTrash);

		boutonRougeBrowser.GetComponent <Button> ();
		boutonRougeBrowser.onClick.AddListener (TaskonClickBoutonRouge);

		wrongButton.GetComponent<Button> ();
		wrongButton.onClick.AddListener (TaskOnClickForgotFacebook);

		question1Button.GetComponent <Button> ();
		question1Button.onClick.AddListener (TaskOnClickQuestionOne);

		TextMeshPro inputfieldQuestion0 = GetComponent <TextMeshPro> ();
		TextMeshPro inputfieldQuestionOne = GetComponent <TextMeshPro> ();

		iconFb.GetComponent <Button> ();
		iconFb.onClick.AddListener (OnClickFacebook);
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

		if (clear == inputfieldWrongText.text) {
			wrongImage.sprite = initial;
		}

		if (ButtonSophie.activeSelf == true) {
			soOpenFacebook = true;
		} else
			soOpenFacebook = false;


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
			wrongImage.sprite = vrai;
			SP.fauxText.SetActive (false);
			SP.vraiText.SetActive (true);
		} else {
			SP.fauxText.SetActive (true);
			SP.vraiText.SetActive (false);
			wrongImage.sprite = pasvrai;
		}

	}

	void TaskOnClickQuestionOne ()
	{
		if ((reponseQuestion1 == inputfieldQuestionOne.text) || (reponseQuestion1a == inputfieldQuestionOne.text)) 
		{
			Debug.Log ("bonne réponse");
			question1Image.sprite = vrai;

		} else {
			question1Image.sprite = pasvrai;
		}
	}

	void OnClickFacebook (){

		if (soOpenFacebook) {
			SP.newsFeedTemplate.SetActive (true);
			SP.NFCass.SetActive (false);
			NFSo.SetActive (true);

		} else {
			SP.newsFeedTemplate.SetActive (true);
			SP.NFCass.SetActive (true);
			NFSo.SetActive (false);
		}

	}

	public void ClearContent (){

		inputfieldWrongText.text = "";
		inputfieldQuestionOne.text = "";

		}
}
