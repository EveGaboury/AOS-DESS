using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonManager: MonoBehaviour {


	public StartPosition SP;
	public GameState GS;
	public SoundDesignScript SDS;
	public AnimatorManager AM;
	public ForceReUpdate FR;


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


	//Question 1 _ Paris
	public Button questionParisButton;
	public Image questionParisImage;
	public TMP_InputField inputfieldQuestionParis;
	private string reponseQuestion1 = "Paris", reponseQuestion1a = "paris";

	//Question_ Picture
	public GameObject adrienQuestion;
	public Button questionAdrienButton;

	//Question 3 _ Zeus
	public TMP_InputField inputfieldQuestionZeus;
	private string reponseQuestionZeus = "Zeus", reponseQuestionZeus2 = "zeus";
	public Button questionZeusButton;
	public Image questionZeusImage;



	private string easter = "pablololol";
	public GameObject pablo;

	[HideInInspector] public string clear ="";

	public Button iconFb;
	public Button shortCutFacebook;

	public Button boutondemarrer_sophie;


	public Toggle toggleNotifCass;
	public Toggle toggleNotifSo;



	void Start () 
	{

		Button btn = bouttontrash.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClickTrash);

		boutonRougeBrowser.GetComponent <Button> ();
		boutonRougeBrowser.onClick.AddListener (TaskonClickBoutonRouge);

		wrongButton.GetComponent<Button> ();
		wrongButton.onClick.AddListener (TaskOnClickForgotFacebook);

		questionParisButton.GetComponent <Button> ();
		questionParisButton.onClick.AddListener (TaskOnClickQuestion1);

		questionAdrienButton.GetComponent <Button> ();
		questionAdrienButton.onClick.AddListener (TaskOnClickQuestion2);

		accueilButton.GetComponent <Button> ();
		accueilButton.onClick.AddListener (GS.accueil);

		TextMeshPro inputfieldQuestion0 = GetComponent <TextMeshPro> ();
		TextMeshPro inputfieldQuestion1 = GetComponent <TextMeshPro> ();
		TextMeshPro inputfieldQuestion2 = GetComponent <TextMeshPro> ();

		iconFb.GetComponent <Button> ();
		iconFb.onClick.AddListener (GS.accueil);
	
		boutondemarrer_sophie.GetComponent <Button> ();
		boutondemarrer_sophie.onClick.AddListener(TaskonClickDemarrer);

		shortCutFacebook.GetComponent <Button> ();
		shortCutFacebook.onClick.AddListener (GS.shortCutFacebook);

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
		SP.mesAmisTemplate.SetActive (false);
		SP.messengerFix.SetActive (false);
		SP.facebookCanvas.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		GS.deactivateChildren ();
		SP.passwordTemplate.SetActive (false);

		SP.notifSo.SetActive (false);
		SP.notifCass.SetActive (false);
		SP.pageProfilTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.mesAmisTemplate.SetActive (false);
		SP.messengerFix.SetActive (false);
		SP.passwordTemplate.SetActive (false);
		SP.fixCass.SetActive (false);
		SP.fixSo.SetActive (false);
		SP.pageNewFeedTemplate.SetActive (false);
		SP.facebook_Image.SetActive (false);
		SP.animloading.SetActive (false);
		SP.onglet_text.SetActive (false);
		SP.avisDeces.SetActive (false);

		SP.profilYann.SetActive (false);
		SP.profilMarieEve2.SetActive (false);
		SP.profilMarieEve1.SetActive (false);
		SP.profilHugo2.SetActive (false);
		SP.profilHugo1.SetActive (false);
		SP.profilAdrien2.SetActive (false);
		SP.profilAdrien1.SetActive (false);
		SP.profilSophie.SetActive (false);
		SP.profilCass.SetActive (false);
		SP.profilFred.SetActive (false);

	}
		
	 void TaskOnClickForgotFacebook ()
	{
		if ((reponsecorrecte == inputfieldWrongText.text) || (reponsecorrecte2 == inputfieldWrongText.text)) {
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundTLRight ();
			SP.questionOne.SetActive (true);
			wrongImage.sprite = vrai;
			SP.fauxText.SetActive (false);
			SP.vraiText.SetActive (true);

		} else {
			SP.fauxText.SetActive (true);
			SP.vraiText.SetActive (false);
			wrongImage.sprite = pasvrai;
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundTLWrong ();
		}
	}

	void TaskOnClickQuestion1 ()
	{
		if ((reponseQuestion1 == inputfieldQuestionParis.text) || (reponseQuestion1a == inputfieldQuestionParis.text))
		{
			Debug.Log ("bonne réponse");
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundTLRight ();
			questionParisImage.sprite = vrai;
			SP.question2.SetActive (true);
			Canvas.ForceUpdateCanvases ();
		} else {
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundTLWrong ();
			questionParisImage.sprite = pasvrai;
			Canvas.ForceUpdateCanvases ();
		}

		if (easter == inputfieldQuestionParis.text) {
			pablo.SetActive (true);
		}
	}

	void TaskOnClickBoutton ()
	{
		adrienQuestion.SetActive (true);
	}


	void TaskOnClickQuestion2 ()
	{
		if ((reponseQuestionZeus == inputfieldQuestionZeus.text) || (reponseQuestionZeus2 == inputfieldQuestionZeus.text)) {
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundTLRight ();
			questionZeusImage.sprite = vrai;
			SP.bouttonfinal.SetActive (true);
			Canvas.ForceUpdateCanvases ();
		} else {
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundTLWrong ();
			questionZeusImage.sprite = pasvrai;
			Canvas.ForceUpdateCanvases ();
		}
	}



	void TaskonClickDemarrer ()
	{
		SP.imageIntro.SetActive (false);
		SDS.GetComponent<SoundDesignScript> ().OnClickSoundNotificationCourriel ();
		AM.popUpAnim ();
	}

		
	public void ClearContent ()
	{
		inputfieldWrongText.text = "";
		inputfieldQuestionParis.text = "";
	}
}
