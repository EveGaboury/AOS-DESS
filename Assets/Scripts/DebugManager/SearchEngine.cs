﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class SearchEngine: MonoBehaviour
{
	public GameObject deleteButton;
	[HideInInspector] public TMP_InputField searchBar;
	public TextMeshProUGUI inputText;
	bool notActive = false, clearOnceDone;

	public StartPosition SP;
	public SoundDesignScript SDS;
	public GameState GS;

	public Sprite finalFacebook;

	public bool shortcutFB = false;

	void Start()
	{
		//ClearContent ();
		TextMeshPro searchBar = GetComponent<TextMeshPro>();
	}

	void OnDisable()
	{
		ClearContent ();
	}
		
    //prend une chaine de charactere, puis renvoit un resultat
    public void SearchFacebook(string userSearch)
	{
		//mettre ça dans une fonction pour déterminer quel est l'engin en train d'être chercher
		if ((searchBar.text == "www.tonlivre.com") || (searchBar.text == "tonlivre.com") || (searchBar.text == "www.avis-de-décès-cassandra-royer.fr") || (searchBar.text == "avis-de-décès-cassandra-royer.fr") || (searchBar.text == "www.avis-de-deces-cassandra-royer.fr") || (searchBar.text == "avis-de-deces-cassandra-royer.fr"))
		{
			SP.facebook_Image.SetActive (false);
			SP.loading_Onglet.SetActive (true);
			StopAllCoroutines ();
			StartCoroutine (WaitAlloTrue ());
		} else 
		{
			SP.facebook_Image.SetActive (false);
			SP.loading_Onglet.SetActive (true);
			StopAllCoroutines ();
			StartCoroutine (WaitAlloWrong ());
			SP.shortCutFacebook.SetActive (false);
			SP.onglet_text.SetActive (false);
		}
	}
	public void ClearContent()
	{
		searchBar.text = "";
	}

	IEnumerator WaitAlloTrue()
	{
		yield return new WaitForSeconds(3f);

		if ((searchBar.text == "www.tonlivre.com") || (searchBar.text == "tonlivre.com")) 
		{
			GS.deconnectionFB ();
			SP.facebookimage.SetActive (true);
			SP.onglet_text.SetActive (true);	
			SP.facebookCanvas.SetActive (true);
			SP.facebookConnexion.SetActive (true);
			SP.facebookConnInPage.SetActive (true);
			SP.notFound.SetActive (false);
			SP.pageProfilTemplate.SetActive (false);
			SP.buttonHeaderCass.SetActive (false);
			SP.passwordTemplate.SetActive (false);
			SP.animloading.SetActive (false);
			SP.shortCutFacebook.SetActive (true);
			SP.messengerTemplate2.SetActive (false);
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundBrowserRight (); 
			shortcutFB = true;
		
		} 

		if ((searchBar.text == "www.avis-de-décès-cassandra-royer.fr") || (searchBar.text == "avis-de-décès-cassandra-royer.fr") || (searchBar.text == "www.avis-de-deces-cassandra-royer.fr") || (searchBar.text == "avis-de-deces-cassandra-royer.fr"))
		{
			Debug.Log ("avis is correct");
			SDS.GetComponent<SoundDesignScript> ().OnclickSoundBrowserRight (); 
			SP.avisDeces.SetActive (true);
			SP.notFound.SetActive (false);
			SP.shortCutDeces.SetActive (true);
			SP.facebookCanvas.SetActive (false);
			SP.messengerTemplate2.SetActive (false);
			SP.shortCutFacebook.SetActive (false);
		} 
	}

	IEnumerator WaitAlloWrong()
	{
		yield return new WaitForSeconds(2f);

		SP.notFound.SetActive (true);
		SP.facebookCanvas.SetActive (false);
		SP.animloading.SetActive (false);
		SDS.GetComponent<SoundDesignScript> ().OnclickSoundBrowserError (); 
	}


	public void shortcuFB ()
	{
		if (shortcutFB ==true)
			SP.shortCutFacebook.SetActive (true);
	}
}


//    public  void SearchYoutube()
//    {
//
//		if (searchBar.text == "youtube.com" ) 
//		{
//			Debug.Log ("your query is correct");
//		} 
//		else 
//		{
//			Debug.Log ("your query is in-correct");
//		}
//
//		ClearContent ();
//    


//Sert à gérer les entrées de clavier dans l'inputField
//	public void UpdateInputField()
//	{
//		Debug.Log("Data has been inputed");
//
//		if (searchBar.text == "")
//		{
//			deleteButton.SetActive(false)
//		}
//		else
//		{
//			searchBar.ActivateInputField ();
//			searchBar.Select ();
//			deleteButton.SetActive(true);
//		}
//	}
