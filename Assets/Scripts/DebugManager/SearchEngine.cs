﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SearchEngine: MonoBehaviour
{
	public GameObject deleteButton;
	[HideInInspector] public TMP_InputField searchBar;
	public TextMeshProUGUI inputText;
	bool notActive = false, clearOnceDone;

	public StartPosition SP;

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
		//regarder documentation pour comparer les string de characters cf. 'Compare' && regarder egalement dictionnaire et hasmap
		//avoir absolulent une emum avec tous les id des pages de facebook, different de les diesable (utiliser un 'pageswitcher')
		if (userSearch == "Sophie") 
		{
			//retourne id de la page pour spophie
		}

		//mettre ça dans une fonction pour déterminer quel est l'engin en train d'être chercher
		if (searchBar.text == "facebook.com") 
		{
			Debug.Log ("facebook is correct");
			SP.facebookCanvas.SetActive (true);
			SP.facebookConnexion.SetActive (true);
			SP.notFound.SetActive (false);
			SP.pageProfilTemplate.SetActive (false);
			SP.buttonCass.SetActive (false);

		} 
		else 
		{
			Debug.Log ("facebook is in-correct");
			SP.notFound.SetActive (true);
			SP.facebookCanvas.SetActive (false);
			//ClearContent ();
		}


		if (searchBar.text == "google.com") {
			Debug.Log ("google is correct");
			SP.shortCut.SetActive (true);
			SP.notFound.SetActive (false);
		} else
			SP.shortCut.SetActive (false);


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

	public void ClearContent()
	{

		searchBar.text = "";
		//inputText.GetComponent<TextMeshProUGUI> ().text = "";
	}
}