using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonManager: MonoBehaviour {


	public StartPosition SP;
	public GameState GS;

	public Button iconFb;

	//boutton corbeille
	public Button bouttontrash;

	//bouton Browser
	public Button boutonRougeBrowser;

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
	private string easter = "pablololol";
	public GameObject pablo;


	public Button question3Button;
	public Image question3Image;
	public TMP_InputField inputfieldQuestion3;
	private string reponseQuestion3 = "Paris";

	[HideInInspector] public string clear ="";


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

		question3Button.GetComponent <Button> ();
		question3Button.onClick.AddListener (TaskOnClickQuestion3);


		TextMeshPro inputfieldQuestion0 = GetComponent <TextMeshPro> ();
		TextMeshPro inputfieldQuestionOne = GetComponent <TextMeshPro> ();
		TextMeshPro inputfieldQuestion2 = GetComponent <TextMeshPro> ();

		iconFb.GetComponent <Button> ();
		iconFb.onClick.AddListener (OnClickFacebook);
	
	}
		

	void TaskOnClickTrash () 
	{
		if (GS.SoOpen) 
		{
			SP.folderTrashSophie.SetActive (true);
		} else {
			SP.folderTrashCass.SetActive (true);
		}
	}

	void TaskonClickBoutonRouge () 
	{
		SP.facebookHeader.SetActive (false);
		SP.browserCanvas.SetActive (false);
		SP.facebookCanvas.SetActive (false);
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
			SP.question2.SetActive (true);

		} else {
			question1Image.sprite = pasvrai;
		}

		if (easter == inputfieldQuestionOne.text) {
			pablo.SetActive (true);

		}
	}

	void TaskOnClickQuestion3 ()
	{
		if (reponseQuestion3 == inputfieldQuestion3.text) {
			question3Image.sprite = vrai;
			SP.bouttonfinal.SetActive (true);
		} else {
			question3Image.sprite = pasvrai;
		}

	}

	void OnClickFacebook (){

		if (GS.soOpenFacebook) {
			SP.newsFeedTemplate.SetActive (true);
			SP.NFCass.SetActive (false);
			SP.NFSo.SetActive (true);

		} else {
			SP.newsFeedTemplate.SetActive (true);
			SP.NFCass.SetActive (true);
			SP.NFSo.SetActive (false);
		}

	}

	public void ClearContent (){

		inputfieldWrongText.text = "";
		inputfieldQuestionOne.text = "";

		}
}
