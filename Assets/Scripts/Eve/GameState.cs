using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


public class GameState : MonoBehaviour {

	public StartPosition SP;
	public ButtonManager BM;
	public StatutConnection SC;
	public ForceReUpdate FR;
	public scrollRectPosition SRP;


	//game state
	public GameObject sessionCass;
	public bool SoOpen = true;

	//facebook state
	public GameObject ButtonFBSophie;
	public bool soOpenFacebook = false;

	public GameObject suiteConvo;


	void Update (){	
	//game state facebook
	if (ButtonFBSophie.activeSelf == true) {
		soOpenFacebook = true;
	} 
		//icon wrong password facebook
		if (BM.clear == BM.FBconfirmationInputField.text) {
			BM.FBconfirmationImage.sprite = BM.initial;
		}

		if (BM.clear == BM.inputfieldQuestionParis.text) {
			BM.questionParisImage.sprite = BM.initial;
		}

		if (BM.clear == BM.inputfieldQuestionZeus.text) {
			BM.questionZeusImage.sprite = BM.initial;
		}
	}

	public void SoFacebookIsOpen (){

		soOpenFacebook = true;
	}

	public void SoFacebookIsClosed () {
		soOpenFacebook = false;
	}

	public void ChangerSessionButton () {

		SP.switchSessionCanvas.SetActive (true);
		SP.fenetrePoireCanvas.SetActive (false);
		SP.blocNoteCanvas.SetActive (false);
		SP.sessionCass.SetActive (false);
		SP.sessionSo.SetActive (false);
	}
		
	public void SessionCass (){
		SP.sessionSo.SetActive (false);
		SP.switchSessionCanvas.SetActive (false);
		SP.sessionCass.SetActive (true);
		SP.desktopCanvas.SetActive (true);
		SP.browserCanvas.SetActive (false);
		SP.fenetreFolderCass.SetActive (false);
		SP.folderTrashCass.SetActive (false);
		SP.blocNoteCanvas.SetActive (true);
		SP.postFinal.SetActive (true);
	}


	//boutonRouge du Browser
	public void bouttonRouge () {

		SP.facebookCanvas.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
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

		SP.facebookHeader.SetActive (false);
		SP.browserCanvas.SetActive (false);
		SP.facebookCanvas.SetActive (false);
		SP.mesAmisTemplate.SetActive (false);
		SP.messengerFix.SetActive (false);
	}

	//bouton deconnection du facebook
	public void deconnectionFB () {
		
		SP.facebookConnexion.SetActive (true);
		SP.facebookConnInPage.SetActive (true);

		SP.pageNewFeedTemplate.SetActive (false);
		SP.rechercheTemplate.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.facebookHeader.SetActive (false);
		SP.wrongPassword.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.messengerTemplate2.SetActive (false);
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


		BM.toggleNotifCass.isOn = false;
		BM.toggleNotifSo.isOn = false;
	}


	//accueil de TonLivre
	public void accueil ()
	{
		SP.pageProfilTemplate.SetActive (false);
		SP.messengerTemplate2.SetActive (false);

		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.amisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (true);
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (true);
		SP.facebookConnInPage.SetActive (false);
		SP.facebookConnexion.SetActive (false);
		SP.facebookHeader.SetActive (true);
		SP.passwordTemplate.SetActive (false);
		SP.rechercheTemplate.SetActive (false);

		SP.pageNewFeedTemplate.SetActive (false);
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

		if (soOpenFacebook) {
			SP.NFSo.SetActive (true);
			SP.NFCass.SetActive (false);
			SP.buttonHeaderSophie.SetActive (true);
			SP.buttonHeaderCass.SetActive (false);
			SP.toggleNotifSo.SetActive (true);
			SP.toggleNotifCass.SetActive (false);
		} else {
			SP.NFSo.SetActive (false);
			SP.NFCass.SetActive (true);
			SP.buttonHeaderCass.SetActive (true);
			SP.buttonHeaderSophie.SetActive (false);
			SP.toggleNotifSo.SetActive (false);
			SP.toggleNotifCass.SetActive (true);
		}
	}

	//mesAmis de TonLivre
	public void mesAmis ()
	{
		SP.newsFeedTemplate.SetActive (false);
		SP.NFCass.SetActive (false);
		SP.NFSo.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.rechercheTemplate.SetActive (false);

		SP.mesAmisTemplate.SetActive (true);
		if (soOpenFacebook) {
			SP.mesAmisSo.SetActive (true);
			SP.mesAmisCass.SetActive (false);
		} else {
			SP.mesAmisCass.SetActive (true);
			SP.mesAmisSo.SetActive (false);
		}
	}

	public void Deconnection ()
	{
		SP.facebookConnexion.SetActive (true);
		SP.facebookHeader.SetActive (false);
		SP.pageNewFeedTemplate.SetActive (false);
		SP.fixSo.SetActive (false);
		SP.fixCass.SetActive (false);
		SP.rechercheTemplate.SetActive (false);
		SP.notifCass.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.pageProfilTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.messengerFix.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.wrongPassword.SetActive (false);
		SP.mesAmisTemplate.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.notifCass.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.facebookConnInPage.SetActive (true);

		BM.toggleNotifCass.isOn = false;
		BM.toggleNotifSo.isOn = false;
	}
		
	public void Messenger () {

		SP.messengerTemplate.SetActive (true);
		SP.messengerFix.SetActive (true);

		SP.rechercheTemplate.SetActive (false);
		SP.pageProfilTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.mesAmisFix.SetActive (false);

		SP.pageNewFeedTemplate.SetActive (false);
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
	
		if (soOpenFacebook) {
			SP.fixSo.SetActive (true);
			SP.SoMessMarieEveMessenger.SetActive (true);
			SP.messengerTemplate.SetActive (true);
		} else {
			SP.fixCass.SetActive (true);
		}

			SP.fixCass.SetActive (false);
			deactivateChildren ();
			SP.messengerTemplate.SetActive (true);
			SC.OnClick_Messenger ();
			SP.SoMessMarieEveMessenger.SetActive (true);
			SP.messengerTemplate2.SetActive (false);
			suiteConvo.SetActive (true);
			ChildrenSuiteConvo ();
			FR.OnEnable ();
	}

	public void shortCutFacebook () {

		SP.facebookCanvas.SetActive (true);
		SP.facebookConnexion.SetActive (true);
		SP.mesAmisFix.SetActive (false);
		SP.facebookConnInPage.SetActive (true);
		SP.facebook_Image.SetActive (true);
		SP.onglet_text.SetActive (true);

	}
		
	public void InputFieldSearch () {

		SP.rechercheTemplate.SetActive (true);

		SP.pageNewFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.pageProfilTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.mesAmisTemplate.SetActive (false);
		SP.passwordTemplate.SetActive (false);
		SP.facebookConnInPage.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.messengerFix.SetActive (false);

	}
		
	public void BoutonSophie () 
	{
		SP.pageProfilTemplate.SetActive (true);
		SP.facebookInfoScriptable.SetActive (true);
		SP.pageNewFeedTemplate.SetActive (true);
		SP.messengerTemplate2.SetActive (false);

		SP.profilSophie.SetActive (true);
		SP.profilCass.SetActive (false);
		SP.profilMarieEve1.SetActive (false);
		SP.profilMarieEve2.SetActive (false);
		SP.profilHugo1.SetActive (false);
		SP.profilHugo2.SetActive (false);
		SP.profilYann.SetActive (false);
		SP.profilAdrien1.SetActive (false);
		SP.profilAdrien2.SetActive (false);
		SP.profilFred.SetActive (false);

		SP.profilSoScriptable.SetActive (true);
		SP.profilCassScriptable.SetActive (false);
		SP.profilAdrienScriptable.SetActive (false);
		SP.profilHugoScriptable.SetActive (false);
		SP.profilYannScriptable.SetActive (false);
		SP.profilMarieEveScriptable.SetActive (false);

		SP.mesAmisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.rechercheTemplate.SetActive (false);
	}

	public void BoutonCass () 
	{
		SP.pageProfilTemplate.SetActive (true);
		SP.facebookInfoScriptable.SetActive (true);
		SP.pageNewFeedTemplate.SetActive (true);


		SP.profilCass.SetActive (true);
		SP.profilSophie.SetActive (false);
		SP.profilMarieEve1.SetActive (false);
		SP.profilMarieEve2.SetActive (false);
		SP.profilHugo1.SetActive (false);
		SP.profilHugo2.SetActive (false);
		SP.profilYann.SetActive (false);
		SP.profilAdrien1.SetActive (false);
		SP.profilAdrien2.SetActive (false);
		SP.profilFred.SetActive (false);

		SP.profilCassScriptable.SetActive (true);
		SP.profilSoScriptable.SetActive (false);
		SP.profilAdrienScriptable.SetActive (false);
		SP.profilHugoScriptable.SetActive (false);
		SP.profilYannScriptable.SetActive (false);
		SP.profilMarieEveScriptable.SetActive (false);

		SP.mesAmisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.rechercheTemplate.SetActive (false);
	}

	public void BoutonAdrien ()
	{
		SP.pageProfilTemplate.SetActive (true);
		SP.facebookInfoScriptable.SetActive (true);
		SP.pageNewFeedTemplate.SetActive (true);
	
		SP.profilCass.SetActive (false);
		SP.profilSophie.SetActive (false);
		SP.profilMarieEve1.SetActive (false);
		SP.profilMarieEve2.SetActive (false);
		SP.profilHugo1.SetActive (false);
		SP.profilHugo2.SetActive (false);
		SP.profilYann.SetActive (false);
		SP.profilFred.SetActive (false);

		SP.profilAdrienScriptable.SetActive (true);
		SP.profilSoScriptable.SetActive (false);
		SP.profilCassScriptable.SetActive (false);
		SP.profilHugoScriptable.SetActive (false);
		SP.profilYannScriptable.SetActive (false);
		SP.profilMarieEveScriptable.SetActive (false);

		SP.mesAmisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.rechercheTemplate.SetActive (false);

		if (soOpenFacebook) {
			SP.profilAdrien1.SetActive (true);
			SP.profilAdrien2.SetActive (false);
		} else {
			SP.profilAdrien1.SetActive (false);
			SP.profilAdrien2.SetActive (true);
		}
	}

	public void BoutonHugo () 
		{
			SP.pageProfilTemplate.SetActive (true);
			SP.facebookInfoScriptable.SetActive (true);
			SP.pageNewFeedTemplate.SetActive (true);


			SP.profilCass.SetActive (false);
			SP.profilSophie.SetActive (false);
			SP.profilMarieEve1.SetActive (false);
			SP.profilMarieEve2.SetActive (false);
			SP.profilAdrien1.SetActive (false);
			SP.profilAdrien2.SetActive (false);
			SP.profilYann.SetActive (false);
			SP.profilFred.SetActive (false);

			SP.profilAdrienScriptable.SetActive (false);
			SP.profilSoScriptable.SetActive (false);
			SP.profilCassScriptable.SetActive (false);
			SP.profilHugoScriptable.SetActive (true);
			SP.profilYannScriptable.SetActive (false);
			SP.profilMarieEveScriptable.SetActive (false);

			SP.mesAmisTemplate.SetActive (false);
			SP.newsFeedTemplate.SetActive (false);
			SP.messengerTemplate.SetActive (false);
			deactivateChildren ();
			SP.messengerFix.SetActive (false);
			SP.mesAmisFix.SetActive (false);
			SP.notifSo.SetActive (false);
			SP.rechercheTemplate.SetActive (false);

			if (soOpenFacebook){
				SP.profilHugo1.SetActive (true);
				SP.profilHugo2.SetActive (false);
			} else {
				SP.profilHugo1.SetActive (false);
				SP.profilHugo2.SetActive (true);
			}
	}

	public void BoutonMarieEve () 
	{
		SP.pageProfilTemplate.SetActive (true);
		SP.facebookInfoScriptable.SetActive (true);
		SP.pageNewFeedTemplate.SetActive (true);


		SP.profilCass.SetActive (false);
		SP.profilSophie.SetActive (false);
		SP.profilHugo1.SetActive (false);
		SP.profilHugo2.SetActive (false);
		SP.profilAdrien1.SetActive (false);
		SP.profilAdrien2.SetActive (false);
		SP.profilYann.SetActive (false);
		SP.profilFred.SetActive (false);

		SP.profilAdrienScriptable.SetActive (false);
		SP.profilSoScriptable.SetActive (false);
		SP.profilCassScriptable.SetActive (false);
		SP.profilHugoScriptable.SetActive (false);
		SP.profilYannScriptable.SetActive (false);
		SP.profilMarieEveScriptable.SetActive (true);

		SP.mesAmisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.rechercheTemplate.SetActive (false);

		if (soOpenFacebook){
			SP.profilMarieEve1.SetActive (true);
			SP.profilMarieEve2.SetActive (false);
		} else {
			SP.profilMarieEve1.SetActive (false);
			SP.profilMarieEve2.SetActive (true);
		}
	}

	public void BoutonYann () 
	{
		SP.pageProfilTemplate.SetActive (true);
		SP.facebookInfoScriptable.SetActive (true);
		SP.pageNewFeedTemplate.SetActive (true);


		SP.profilCass.SetActive (false);
		SP.profilSophie.SetActive (false);
		SP.profilMarieEve1.SetActive (false);
		SP.profilMarieEve2.SetActive (false);
		SP.profilAdrien1.SetActive (false);
		SP.profilAdrien2.SetActive (false);
		SP.profilHugo1.SetActive (false);
		SP.profilHugo2.SetActive (false);
		SP.profilYann.SetActive (true);
		SP.profilFred.SetActive (false);

		SP.profilAdrienScriptable.SetActive (false);
		SP.profilSoScriptable.SetActive (false);
		SP.profilCassScriptable.SetActive (false);
		SP.profilHugoScriptable.SetActive (false);
		SP.profilYannScriptable.SetActive (true);
		SP.profilMarieEveScriptable.SetActive (false);

		SP.mesAmisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.rechercheTemplate.SetActive (false);

	}

	public void BoutonFred () 
	{
		SP.pageProfilTemplate.SetActive (true);
		SP.facebookInfoScriptable.SetActive (true);
		SP.pageNewFeedTemplate.SetActive (true);


		SP.profilCass.SetActive (false);
		SP.profilSophie.SetActive (false);
		SP.profilMarieEve1.SetActive (false);
		SP.profilMarieEve2.SetActive (false);
		SP.profilAdrien1.SetActive (false);
		SP.profilAdrien2.SetActive (false);
		SP.profilHugo1.SetActive (false);
		SP.profilHugo2.SetActive (false);
		SP.profilYann.SetActive (false);
		SP.profilFred.SetActive (true);

		SP.profilAdrienScriptable.SetActive (false);
		SP.profilSoScriptable.SetActive (false);
		SP.profilCassScriptable.SetActive (false);
		SP.profilHugoScriptable.SetActive (false);
		SP.profilYannScriptable.SetActive (false);
		SP.profilMarieEveScriptable.SetActive (false);

		SP.mesAmisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		deactivateChildren ();
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.notifSo.SetActive (false);
		SP.rechercheTemplate.SetActive (false);

	}

	public void BoiteMess () {

		SP.C1corps.SetActive (true);
		SP.C1info.SetActive (true);

		SP.C2corps.SetActive (false);
		SP.C3corps.SetActive (false);
		SP.C4corps.SetActive (false);
		SP.C5corps.SetActive (false);
		SP.C6corps.SetActive (false);
		SP.CT2corps.SetActive (false);
		SP.CB1corps.SetActive (false);

		SP.C2info.SetActive (false);
		SP.C3info.SetActive (false);
		SP.C4info.SetActive (false);
		SP.C5info.SetActive (false);
		SP.C6info.SetActive (false);
		SP.CT2info.SetActive (false);
		SP.CB1info.SetActive (false);
	}

	public void Brouillon () {

		SP.CB1corps.SetActive (true);
		SP.CB1info.SetActive (true);

		SP.C2corps.SetActive (false);
		SP.C3corps.SetActive (false);
		SP.C4corps.SetActive (false);
		SP.C5corps.SetActive (false);
		SP.C6corps.SetActive (false);
		SP.CT2corps.SetActive (false);
		SP.C1corps.SetActive (false);

		SP.C2info.SetActive (false);
		SP.C3info.SetActive (false);
		SP.C4info.SetActive (false);
		SP.C5info.SetActive (false);
		SP.C6info.SetActive (false);
		SP.CT2info.SetActive (false);
		SP.C1info.SetActive (false);

	}

	public void Corbeille () {
		
		SP.CT2corps.SetActive (true);
		SP.CT2info.SetActive (true);

		SP.C2corps.SetActive (false);
		SP.C3corps.SetActive (false);
		SP.C4corps.SetActive (false);
		SP.C5corps.SetActive (false);
		SP.C6corps.SetActive (false);
		SP.CB1corps.SetActive (false);
		SP.C1corps.SetActive (false);

		SP.C2info.SetActive (false);
		SP.C3info.SetActive (false);
		SP.C4info.SetActive (false);
		SP.C5info.SetActive (false);
		SP.C6info.SetActive (false);
		SP.CB1info.SetActive (false);
		SP.C1info.SetActive (false);
	}

	public void deactivateChildren () 
	{
		LayoutElement[] allChildren = SP.messengerTemplate.GetComponentsInChildren<LayoutElement>();

		foreach (LayoutElement item in allChildren)
		{
			item.gameObject.SetActive (false);
		}
	}
		

	public void ChildrenSuiteConvo()
	{
		foreach (Transform child in suiteConvo.transform)
		{
			child.gameObject.SetActive(true);
		}
	}

	public void MessengerSoME () {

		SP.fixCass.SetActive (false);
		SP.messengerTemplate.SetActive (true);
		SP.SoMessMarieEveMessenger.SetActive (true);
		SP.messengerTemplate2.SetActive (false);
		suiteConvo.SetActive (true);
		SC.OnClick_Messenger ();
		ChildrenSuiteConvo ();
		FR.OnEnable ();
	}

	public void MessengerSoCass (){

		suiteConvo.SetActive (false);
		SP.fixCass.SetActive (false);
		SP.SoMessPoMessenger.SetActive (false);
		SP.SoMessYoMessenger.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		SP.messengerTemplate2.SetActive (true);
		SP.SoMessCassMessenger.SetActive (true);
		SP.SoMessCassMessenger.transform.SetAsFirstSibling ();
		SC.InitialState ();
		deactivateChildren ();
		SRP.InvertStart ();
		FR.OnEnable ();
	}

	public void MessengerSoYann (){

		suiteConvo.SetActive (false);
		SP.fixCass.SetActive (false);
		SP.SoMessCassMessenger.SetActive (false);
		SP.SoMessPoMessenger.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		SP.messengerTemplate2.SetActive (true);
		SP.SoMessYoMessenger.SetActive (true);
		SP.SoMessYoMessenger.transform.SetAsFirstSibling ();
		SC.InitialState ();
		deactivateChildren ();
		SRP.InvertStart ();
		FR.OnEnable ();
	}

	public void MessengerSoPO (){

		suiteConvo.SetActive (false);
		SP.fixCass.SetActive (false);
		SP.SoMessCassMessenger.SetActive (false);
		SP.SoMessYoMessenger.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		SP.messengerTemplate2.SetActive (true);
		SP.SoMessPoMessenger.SetActive (true);
		SP.SoMessPoMessenger.transform.SetAsFirstSibling ();
		SC.InitialState ();
		deactivateChildren ();
		SRP.InvertStart ();
		FR.OnEnable ();
	}
}