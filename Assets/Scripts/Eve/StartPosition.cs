using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour {

	//gamobjects commun
	public GameObject switchSessionCanvas;
	public GameObject blocNoteCanvas;
	public GameObject fenetrePoireCanvas;

	//gameobjects Cass
	public GameObject desktopCass;

	// gameobjects Sophie
	public GameObject desktopSophie;
	public GameObject fenetreFolderSophie;


	void Start () 
	{
		switchSessionCanvas.SetActive (false);
		blocNoteCanvas.SetActive (true);
		fenetrePoireCanvas.SetActive (false);

		desktopCass.SetActive (false);

		desktopSophie.SetActive (true);
		fenetreFolderSophie.SetActive (false);
	}
}


