using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class ErroneousSearchesDirector : MonoBehaviour 
{
	public Image[] portraitsToBeDisplayed;

	public TMP_InputField searchBar;

	TextMeshProUGUI displayText;

	Transform wrongSearchResults;

	int[] minuscules = new int[26], majuscules = new int[26];

	char[] verification = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
						   'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
	
	void Awake()
	{
		wrongSearchResults = GetComponent<Transform>();

		displayText = wrongSearchResults.GetComponentInChildren<TextMeshProUGUI>();

		displayText.text = "";

		searchBar = GetComponent<TMP_InputField> ();

		RetrieveAllImages ();
	}

	public void SortInputedData (string userSearch) 
	{
		userSearch = searchBar.text;

		char firstLetter = userSearch[0];

		if (firstLetter < verification[25] && firstLetter > verification[0]) 
		{
			Debug.Log ("minuscules: " + userSearch);
			BringWrongSearchResultsPanel(userSearch);
		}
		else if(firstLetter < verification[51] && firstLetter > verification[26])
		{
			Debug.Log ("MAJUSCULES: " + userSearch);
			BringWrongSearchResultsPanel (userSearch);
		}
		else
		{
			BringWrongSearchResultsPanel (userSearch);
			Debug.Log ("The greatest FAILURE of: " + userSearch);
		}
	}

	void BringWrongSearchResultsPanel(string userSearch)
	{
		this.gameObject.transform.parent.gameObject.SetActive(true);
		this.gameObject.GetComponentInChildren<TextMeshProUGUI> ().text = userSearch;
	}

	void RetrieveAllImages()
	{
		Component[] imagePosition;

		imagePosition = this.gameObject.GetComponentsInChildren (typeof(Image));

		foreach (Image img in imagePosition)
		{
			Debug.Log("These are the gameObjects with an image component: " + img.name);		
		}
	}

	void OnDisable()
	{
		Debug.Log ("This was a triumph! \n I'm making a note here: \n Huge success!");
		this.gameObject.SetActive (false);
		searchBar.text = "";
	}
}
