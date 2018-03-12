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

	private string reponseCorrecte = "sophie.baillargeon@courriel.ca";
	private string passwordCorrect = "cool";

	public StartPosition SP;
	public GameState GS;



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
		
		if (email.text == reponseCorrecte) 
		{
			if (password.text == passwordCorrect)
			{
				//accesFB ();
				GS.SoFacebookIsOpen();
				GS.accueil ();
				SP.shortCutSophieFB.SetActive (true);

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
		Debug.Log ("clear content");
		email.text = "";
		password.text = "";
		SP.wrongPassword.SetActive (false);
	}
}
