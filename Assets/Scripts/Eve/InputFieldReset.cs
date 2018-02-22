using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldReset : MonoBehaviour {

	public Text inputFieldBrowser;
	public string reset = " " ;
	private bool clear = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (string.IsNullOrEmpty(" ")) {
			clear = false;
			Debug.Log ("ya de la merde écrite");
		} 
		

	
		
	}
}
