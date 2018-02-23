using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartPosition : MonoBehaviour {

	//gamobjects commun
	public GameObject switchSessionCanvas;
	public GameObject blocNoteCanvas;
	public GameObject fenetrePoireCanvas;
	public GameObject browserCanvas;
	public GameObject facebookConnexionCanvas;
	public GameObject gmailCanvas;
	 

	// gameobjects Sophie
	public GameObject desktopImageSophie;

	//gameobjects Cass
	public GameObject desktopImageCass;


	void Start () 
	{
		switchSessionCanvas.SetActive (false);
		blocNoteCanvas.SetActive (true);
		fenetrePoireCanvas.SetActive (false);
		browserCanvas.SetActive (false);
		facebookConnexionCanvas.SetActive (false);
		desktopImageCass.SetActive (false);	
		gmailCanvas.SetActive (false);
	}
}


