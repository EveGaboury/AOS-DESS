using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager: MonoBehaviour {


	//game state
	public GameObject sessionCass;
	public bool SoOpen = true;


	//boutton corbeille
	public Button bouttontrash;
	public GameObject windowCass;
	public GameObject windowSo; 

	//bouton Browser
	public Button boutonRougeBrowser;

	//GameObject affecté par les bouttons
	public GameObject facebookHeader;
	public GameObject browserCanvas;
	public GameObject facebookCanvas;





	void Start () {

		Button btn = bouttontrash.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClickTrash);

		boutonRougeBrowser.GetComponent <Button> ();
		boutonRougeBrowser.onClick.AddListener (TaskonClickBoutonRouge);


	}

	void Update () {


		//game state
		if (sessionCass.activeSelf == true) {
			SoOpen = false;
		}
		else
		{
			SoOpen = true;
		}
	}

	void TaskOnClickTrash () {

		if (SoOpen) {
			windowSo.SetActive (true);
		} else {
			windowCass.SetActive (true);
		}
	}

	void TaskonClickBoutonRouge () {

		facebookHeader.SetActive (false);
		browserCanvas.SetActive (false);
		facebookCanvas.SetActive (false);
	}
}
