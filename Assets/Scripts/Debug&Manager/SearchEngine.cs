﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SearchEngine: MonoBehaviour
{
	public GameObject deleteButton, falseFacebook, falseYoutube;
	[HideInInspector] public TMP_InputField searchBar;
	public TextMeshProUGUI inputText;
	bool notActive = false, clearOnceDone;

	void Start()
	{
		ClearContent ();
<<<<<<< HEAD

		TextMeshPro searchBar = GetComponent<TextMeshPro>();

		falseFacebook.SetActive (false);
		falseYoutube.SetActive (false);
	}

	void OnDisable()
	{
		ClearContent ();
	}
=======
//		falseFacebook.SetActive (false);
//		falseYoutube.SetActive (false);
	}		
>>>>>>> 2f7ef0cc82b2dfdcae872dbdfe60fd707cdc75da
		
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
			Debug.Log ("your query is correct");

			falseFacebook.SetActive (true);
		} 
		else 
		{
			Debug.Log ("your query is in-correct");
		}

		//ClearContent ();
    }

    public  void SearchYoutube()
    {

		if (searchBar.text == "youtube.com") 
		{
			Debug.Log ("your query is correct");

			falseYoutube.SetActive (true);
		} 
		else 
		{
			Debug.Log ("your query is in-correct");
		}

		//ClearContent ();
    }


	//Sert à gérer les entrées de clavier dans l'inputField
	public void UpdateInputField()
	{
		Debug.Log("Data has been inputed");

		if (searchBar.text == "")
		{
			deleteButton.SetActive(false);
		}
		else
		{
			searchBar.ActivateInputField ();
			searchBar.Select ();
			deleteButton.SetActive(true);
		}
	}

	public void ClearContent()
	{
		searchBar.text = "";
		//inputText.GetComponent<TextMeshProUGUI> ().text = "";
	}

}
