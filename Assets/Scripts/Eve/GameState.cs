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


	
	void Update () 
	{
		//game state
		if (sessionCass.activeSelf == true) {
			SoOpen = false;
		}
		else{
			SoOpen = true;
		}


		if (BM.clear == BM.inputfieldWrongText.text) {
			BM.wrongImage.sprite = BM.initial;
		}

		if (BM.clear == BM.inputfieldQuestionOne.text) {
			BM.question1Image.sprite = BM.initial;
		}

		if (BM.clear == BM.inputfieldQuestion3.text) {
			BM.question3Image.sprite = BM.initial;
		}


		if (ButtonFBSophie.activeSelf == true) {
			soOpenFacebook = true;
		} else
			soOpenFacebook = false;


	}

	public void accueil (){

		SP.pageProfilTemplate.SetActive (false);
		SP.messengerTemplate.SetActive (false);
		SP.amisTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (true);
		SP.messengerFix.SetActive (false);

		if (soOpenFacebook) {
			SP.NFSo.SetActive (true);
			SP.NFCass.SetActive (false);
		} else {
			SP.NFSo.SetActive (false);
			SP.NFCass.SetActive (true);
		}
	}

}
