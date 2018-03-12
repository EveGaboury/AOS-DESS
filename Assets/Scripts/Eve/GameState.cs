﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


public class GameState : MonoBehaviour {

	public StartPosition SP;
	public ButtonManager BM;

	//game state
	public GameObject sessionCass;
	public bool SoOpen = true;

	//facebook state
	public GameObject ButtonFBSophie;
	public bool soOpenFacebook = false;

	
	void Update (){	

	//game state facebook
	if (ButtonFBSophie.activeSelf == true) {
		soOpenFacebook = true;
	} 

		//icon wrong password facebook
		if (BM.clear == BM.inputfieldWrongText.text) {
			BM.wrongImage.sprite = BM.initial;
		}

		if (BM.clear == BM.inputfieldQuestion1.text) {
			BM.question1Image.sprite = BM.initial;
		}

		if (BM.clear == BM.inputfieldQuestion3.text) {
			BM.question3Image.sprite = BM.initial;
		}
	}

	public void SoFacebookIsOpen (){

		soOpenFacebook = true;
	}

	public void SoFacebookIsClosed () {
		soOpenFacebook = false;
	}	

	public void accueil ()
	{
		SP.pageProfilTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		SP.amisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (true);
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (true);
		SP.facebookConnInPage.SetActive (false);
		SP.facebookConnexion.SetActive (false);
		SP.facebookHeader.SetActive (true);
		SP.passwordTemplate.SetActive (false);

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

	public void mesAmis ()
	{
		SP.NFCass.SetActive (false);
		SP.NFSo.SetActive (false);
		SP.mesAmisFix.SetActive (false);


		SP.mesAmisTemplate.SetActive (true);
		if (soOpenFacebook) {
			SP.mesAmisSo.SetActive (true);
			SP.mesAmisCass.SetActive (false);
		} else {
			SP.mesAmisCass.SetActive (true);
			SP.mesAmisSo.SetActive (false);
		}
	}

	public void Messenger () {

		SP.messengerTemplate.SetActive (true);
		SP.messengerFix.SetActive (true);
		SP.fond.SetActive (true);

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
	
		if (soOpenFacebook) {
			SP.messSo.SetActive (true);
			SP.messCass.SetActive (false);
		} else {
			SP.messSo.SetActive (false);
			SP.messCass.SetActive (true);
		}
	}

	public void InputFieldSearch () {

		SP.rechercheTemplate.SetActive (true);

		SP.pageNewFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
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
		SP.profilSophie.SetActive (true);

		SP.profilSoScriptable.SetActive (true);
		SP.profilCassScriptable.SetActive (false);

		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.notifSo.SetActive (false);
	}

	public void BoutonCass () 
	{
		SP.pageProfilTemplate.SetActive (true);
		SP.facebookInfoScriptable.SetActive (true);
		SP.pageNewFeedTemplate.SetActive (true);
		SP.profilCass.SetActive (true);

		SP.profilSoScriptable.SetActive (false);
		SP.profilCassScriptable.SetActive (true);

		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		SP.messengerFix.SetActive (false);
		SP.mesAmisFix.SetActive (false);
		SP.notifSo.SetActive (false);
	}


	//public void 

}
