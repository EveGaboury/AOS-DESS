using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonManager: MonoBehaviour {


	public StartPosition SP;
	public GameState GS;

	//public Button iconFb;
	public Button accueilButton;

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
	public TMP_InputField inputfieldQuestion1;
	private string reponseQuestion1 = "Paris", reponseQuestion1a = "paris";

	public Button question3Button;
	public Image question3Image;
	public TMP_InputField inputfieldQuestion3;
	private string reponseQuestion3 = "Zeus", reponseQuestion3a = "zeus";
	private string easter = "pablololol";
	public GameObject pablo;

	[HideInInspector] public string clear ="";

	public Button iconFb;


	void Start () 
	{

		Button btn = bouttontrash.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClickTrash);

		boutonRougeBrowser.GetComponent <Button> ();
		boutonRougeBrowser.onClick.AddListener (TaskonClickBoutonRouge);

//		wrongButton.GetComponent<Button> ();
//		wrongButton.onClick.AddListener (TaskOnClickForgotFacebook);

//		question1Button.GetComponent <Button> ();
//		question1Button.onClick.AddListener (TaskOnClickQuestion1);

//		question3Button.GetComponent <Button> ();
//		question3Button.onClick.AddListener (TaskOnClickQuestion3);

//		accueilButton.GetComponent <Button> ();
//		accueilButton.onClick.AddListener (GS.accueil);

		TextMeshPro inputfieldQuestion0 = GetComponent <TextMeshPro> ();
		TextMeshPro inputfieldQuestion1 = GetComponent <TextMeshPro> ();
		TextMeshPro inputfieldQuestion2 = GetComponent <TextMeshPro> ();

//		iconFb.GetComponent <Button> ();
//		iconFb.onClick.AddListener (GS.accueil);
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

	void TaskOnClickQuestion1 ()
	{
		if ((reponseQuestion1 == inputfieldQuestion1.text) || (reponseQuestion1a == inputfieldQuestion1.text))
		{
			Debug.Log ("bonne réponse");
			question1Image.sprite = vrai;
			SP.question2.SetActive (true);

		} else {
			question1Image.sprite = pasvrai;
		}

		if (easter == inputfieldQuestion1.text) {
			pablo.SetActive (true);
		}
	}

	void TaskOnClickQuestion3 ()
	{
		if ((reponseQuestion3 == inputfieldQuestion3.text) || (reponseQuestion3a == inputfieldQuestion3.text)) {
			question3Image.sprite = vrai;
			SP.bouttonfinal.SetActive (true);
		} else {
			question3Image.sprite = pasvrai;
		}
	}
		
	public void ClearContent ()
	{
		inputfieldWrongText.text = "";
		inputfieldQuestion1.text = "";
	}

	public void bouttonRouge () {

		SP.facebookCanvas.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.notifCass.SetActive (false);
		SP.pageProfilTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.mesAmisTemplate.SetActive (false);
		SP.messengerFix.SetActive (false);
		SP.passwordTemplate.SetActive (false);
		SP.fixCass.SetActive (false);
		SP.fixSo.SetActive (false);
	}

}
