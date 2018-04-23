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
	public scrollRectPosition SRP;
	public DialogueManager DM;
	public FadeOutScript FOS;


	//public Button iconFb;
	public Button accueilButton;

	//boutton corbeille
	public Button bouttontrash;

	//bouton Browser
	public Button boutonRougeBrowser;

	//===========================================================================================================

	//inputfield et boutton pour facebook mot de passe
	public Button FBconfirmationButton;
	public Image FBconfirmationImage;
	public TMP_InputField FBconfirmationInputField;
	private string reponsecorrecteCass = "cassandraroyer@courriel.fr", reponsecorrecte2Cass = "Cassandraroyer@courriel.fr" ; 

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

	public VerticalLayoutGroup _vertLayoutGroup;
	public ContentSizeFitter _ContentSizeFitter;


	private string easter = "pablololol";
	public GameObject pablo;

	[HideInInspector] public string clear ="";

	public Button iconFb;
	public Button shortCutFacebook;

	public Button boutondemarrer_sophie;


	public Toggle toggleNotifCass;
	public Toggle toggleNotifSo;

	//Introduction_Diacticiel


//	public Button firstData;
//	public Button EndTuto;
//	public GameObject leDevoir; 




	void Start () 
	{

		Button btn = bouttontrash.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClickTrash);

		boutonRougeBrowser.GetComponent <Button> ();
		boutonRougeBrowser.onClick.AddListener (TaskonClickBoutonRouge);

		FBconfirmationButton.GetComponent<Button> ();
		FBconfirmationButton.onClick.AddListener (TaskOnClickForgotFacebook);

		questionParisButton.GetComponent <Button> ();
		questionParisButton.onClick.AddListener (TaskOnClickQuestion1);

		questionAdrienButton.GetComponent <Button> ();
		questionAdrienButton.onClick.AddListener (TaskOnClickQuestionAdrien);

		questionZeusButton.GetComponent <Button> ();
		questionZeusButton.onClick.AddListener (TaskOnClickQuestion2);

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



//		firstData.GetComponent <Button> ();
//		firstData.onClick.AddListener (TaskOnFirstData);
//
//
//		EndTuto.GetComponent <Button> ();
//		EndTuto.onClick.AddListener (TaskOnEndTuto);
//
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
		if ((reponsecorrecteCass == FBconfirmationInputField.text) || (reponsecorrecte2Cass == FBconfirmationInputField.text)) {
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundTLRight ();
			SP.questionOne.SetActive (true);
			FBconfirmationImage.sprite = vrai;
			SP.fauxText.SetActive (false);
			SP.vraiText.SetActive (true);

		} else {
			SP.fauxText.SetActive (true);
			SP.vraiText.SetActive (false);
			FBconfirmationImage.sprite = pasvrai;
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

	void TaskOnClickQuestionAdrien (){
		
		SP.question3.SetActive (true);
		DM.boulesale = true;
		DM.Update ();
		Canvas.ForceUpdateCanvases();
		_vertLayoutGroup.SetLayoutVertical();
		_ContentSizeFitter.enabled = true;
		_ContentSizeFitter.SetLayoutVertical();
		LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)SP.passwordTemplate.transform );
		_ContentSizeFitter.enabled = false;
	}


	void TaskOnClickQuestion2()
	{
		if ((reponseQuestionZeus == inputfieldQuestionZeus.text) || (reponseQuestionZeus2 == inputfieldQuestionZeus.text)) {
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundTLRight ();
			questionZeusImage.sprite = vrai;
			SP.bouttonfinal.SetActive (true);
			Canvas.ForceUpdateCanvases();
			_vertLayoutGroup.SetLayoutVertical();
			_ContentSizeFitter.enabled = true;
			_ContentSizeFitter.SetLayoutVertical();
			LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)SP.passwordTemplate.transform );
			_ContentSizeFitter.enabled = false;

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
		FBconfirmationInputField.text = "";
		inputfieldQuestionParis.text = "";
	}



	void TaskOnFirstData() 
	{

		FOS.startFading ();


		//lancer l'animation de la croix
		//Lancer changement de la musique pour déut du jeu

	}

	void TaskOnEndTuto() 
	{
		//c'est le boutonCroix.

		//lancer l'animation de la croix
		//Lancer changement de la musique pour déut du jeu
	//

	}
}
