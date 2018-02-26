﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PasswordFb : MonoBehaviour {


	public Button deleteButton;
	public TMP_InputField password;

	public Button connexion;

	public EmailFb eS;
	public GameObject pageConnexion;
	public GameObject pageProfil;
	public GameObject passWordIncorrect;

	public StartPosition sP;



	void Start () 
	{

		//TextMeshPro email = GetComponent<TextMeshPro> ();
		TextMeshPro password = GetComponent<TextMeshPro> ();

	
	}

	void OnDisable()
	{
		ClearContent ();
	}


	public void Search(string userSearch)
	{
		
		if (password.text == "cool") {
			Debug.Log ("your second query is correct");
			if (eS.email.text == "jessica") {
				Debug.Log ("your every queris is correct");
				pageConnexion.SetActive (false);
				pageProfil.SetActive (true);
				sP.facebookHeader.SetActive (true);

			}
		}	else 
		{
			Debug.Log ("your second query is in-correct");
			ClearContent ();
			eS.ClearContent ();
			passWordIncorrect.SetActive (true);
		}
	}



	public void ClearContent()
	{
		Debug.Log ("clear content");
		password.text = "";
		passWordIncorrect.SetActive (false);
	}
}
