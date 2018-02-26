using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EmailFb : MonoBehaviour {


	public Button deleteButton;
	public TMP_InputField email;
	//public TMP_InputField password;

	public Button connexion;

	// Use this for initialization
	void Start () 
	{

		TextMeshPro email = GetComponent<TextMeshPro> ();
		//TextMeshPro password = GetComponent<TextMeshPro> ();

	
	}

	void OnDisable()
	{
		ClearContent ();
	}

	//prend une chaine de charactere, puis renvoit un resultat

	public void Search(string userSearch)
	{
		
		if (email.text == "jessica")  
		{
			Debug.Log ("your first query is correct");

		} 
		else 
		{
			Debug.Log ("your first query is in-correct");
			//ClearContent ();
		}


	}



	public void ClearContent()
	{
		Debug.Log ("clear content");
		email.text = "";
		//password.text = "";
	}
}
