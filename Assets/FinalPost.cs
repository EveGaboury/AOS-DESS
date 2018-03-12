using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class FinalPost : MonoBehaviour {

	public TMP_InputField SearchField;
	public TextMeshProUGUI inputText;

	public Button postButton;



	// Use this for initialization
	void Start () {
		
		TextMeshPro searchField = GetComponent<TextMeshPro>();
		
	}

	public void SearchPost(string userSearch)
	{
		if (SearchField.text == "www.avis-deces-cassandra-royer.fr") {
			postButton.GetComponent<Button> ().enabled = true;
		}
	}
}
