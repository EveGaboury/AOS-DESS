using System.Collections;
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

		SP.pageProfilTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (true);
		SP.messengerFix.SetActive (true);
		SP.mesAmisFix.SetActive (false);
	

		if (soOpenFacebook) {
			SP.messSo.SetActive (true);
			SP.messCass.SetActive (false);
		} else {
			SP.messSo.SetActive (false);
			SP.messCass.SetActive (true);
		}

	}


	public void SoFacebookIsOpen (){

		soOpenFacebook = true;
	}

	public void SoFacebookIsClosed () {
		soOpenFacebook = false;
	}
}
