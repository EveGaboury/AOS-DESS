using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EmailFb : MonoBehaviour {


	//public Button deleteButton;
	public TMP_InputField email;
	public TMP_InputField password;

	public Button connexion;

	private string reponseCorrecte = "sophie", responseCorrecte2 = "Sophie";
	//private string reponserCorrecte2 = "Sophie.baillargeon@gmail.com";
	private string passwordCorrect = "cool";

	public StartPosition SP;



	// Use this for initialization
	void Start () 
	{

		TextMeshPro email = GetComponent<TextMeshPro> ();
		TextMeshPro password = GetComponent<TextMeshPro> ();
		TextMeshPro emailSecond = GetComponent <TextMeshPro> ();
	}

	void OnDisable()
	{
		ClearContent ();
	}

	//prend une chaine de charactere, puis renvoit un resultat

	public void Search(string userSearch)
	{
		if (password.text != passwordCorrect) 
		{
			Debug.Log ("your second query is in-correct");
			SP.wrongPassword.SetActive (true);
		}
		
		if (email.text == reponseCorrecte || email.text == responseCorrecte2) 
		{
			if (password.text == passwordCorrect)
			{
				accesFB ();
			} 
		}
		else if (email.text != reponseCorrecte)
		{
			Debug.Log ("your first query is in-correct");
			SP.wrongPassword.SetActive (true);
		}



	}

	public void accesFB ()
	{
		Debug.Log ("your first query is correct");
		SP.pageProfilTemplate.SetActive (true);
		SP.facebookConnexion.SetActive (false);
		SP.facebookConnInPage.SetActive (false);
		SP.facebookHeader.SetActive (true);
		SP.pageProfilTemplate.SetActive (false);
		SP.newsFeedTemplate.SetActive (true);
		SP.passwordTemplate.SetActive (false);
	}




	public void ClearContent()
	{
//		Debug.Log ("clear content");
		email.text = "";
		password.text = "";
		SP.wrongPassword.SetActive (false);
	}
}
