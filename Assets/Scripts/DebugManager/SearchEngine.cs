
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
		Debug.Log ("clear");
		ClearContent ();
	}


    //prend une chaine de charactere, puis renvoit un resultat
    public void SearchFacebook(string userSearch)
    {

		//mettre ça dans une fonction pour déterminer quel est l'engin en train d'être chercher
		if (searchBar.text == "www.tonlivre.com") 
		{
			Debug.Log ("facebook is correct");
			SP.facebookCanvas.SetActive (true);
			SP.facebookConnexion.SetActive (true);
			SP.facebookConnInPage.SetActive (true);
			SP.notFound.SetActive (false);
			SP.pageProfilTemplate.SetActive (false);
			SP.buttonHeaderCass.SetActive (false);
			SP.passwordTemplate.SetActive (false);
			SP.shortCutFacebook.SetActive (true);

		} 
		else 
		{
			Debug.Log ("facebook is in-correct");
			SP.notFound.SetActive (true);
			SP.facebookCanvas.SetActive (false);

		}


		if (searchBar.text == "www.google.com") {
			Debug.Log ("google is correct");
			SP.shortCut.SetActive (true);
			SP.notFound.SetActive (false);
		} else
			SP.shortCut.SetActive (false);

		if (searchBar.text == "www.avis-deces-cassandra-royer.fr") {
			Debug.Log ("avis is correct");
			SP.avisDeces.SetActive (true);
			SP.notFound.SetActive (false);
			SP.shortCutDeces.SetActive (true);
		} else
			SP.notFound.SetActive (true);
		
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
		Debug.Log ("clear2");
		searchBar.text = "";

	}
}
