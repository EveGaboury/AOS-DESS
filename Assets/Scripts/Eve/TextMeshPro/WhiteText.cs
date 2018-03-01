using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WhiteText : MonoBehaviour {

	private TextMeshPro w_TextMeshPro;

	// Use this for initialization
	void Start () {

		w_TextMeshPro = GetComponent<TextMeshPro> ();

		w_TextMeshPro.color = Color.white;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
