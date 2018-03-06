using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ErroneousSearchesDirector : MonoBehaviour 
{
	public GameObject wrongSearchResults;

	TextMeshProUGUI displayText;

	int[] minuscules = new int[26], majuscules = new int[26];

//	char[] majusculesss = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
//	char[] minusculessss = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
		

	char[] verification = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
						   'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
	
	void Awake()
	{
		displayText = wrongSearchResults.GetComponentInChildren<TextMeshProUGUI>();

		displayText.text = "";
	}

	public void Hello_World (string userSearch) 
	{
		char firstLetter = userSearch[0];

		if (firstLetter < verification[25] && firstLetter > verification[0]) 
		{
			Debug.Log ("VICTORY: " + userSearch);
			wrongSearchResults.SetActive (true);
		}
		else if(firstLetter < verification[51] && firstLetter > verification[26])
		{
			Debug.Log ("VICTORY: " + userSearch);
		}
		else
		{
			Debug.Log ("The greatest FAILURE of: " + userSearch);
		}
	}

	void OnDisable()
	{
		Debug.Log ("This was a triumph! \n I'm making a note here: \n Huge success!");
		wrongSearchResults.SetActive (false);
		this.gameObject.GetComponent<TMP_InputField> ().text = "";
	}
}
