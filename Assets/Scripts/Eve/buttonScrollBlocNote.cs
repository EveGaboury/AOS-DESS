using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScrollBlocNote : MonoBehaviour {

	public Scrollbar scrollBlocNote;
	public Button boutonHaut;
	public Button boutonBas;

	// Use this for initialization
	void Start () {

		scrollBlocNote = GetComponent <Scrollbar> ();

		boutonHaut.GetComponent <Button> ();

		boutonBas.GetComponent <Button> ();

	
	}


	public void Haut (){

		scrollBlocNote.value = 1f;
		Debug.Log ("HAUT");
	}

	public void Bas (){

		scrollBlocNote.value = 0f;
		Debug.Log ("BAS");
	}
}
