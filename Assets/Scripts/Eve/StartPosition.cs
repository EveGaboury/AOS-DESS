using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartPosition : MonoBehaviour {

	//gamobjects commun
	public GameObject switchSessionCanvas;
	public GameObject blocNoteCanvas;
	public GameObject fenetrePoireCanvas;
	public GameObject browserCanvas;
	public GameObject elementsCommun;

	public GameObject facebookConnexionCanvas;
	public GameObject facebookHeader;

	public GameObject gmailCanvas;
	public GameObject listContentMess;
	public GameObject listContentEcole;
	public GameObject listContentImportant;
	public GameObject listContentBrouillon;
	public GameObject listContentTrash;


	 

	// gameobjects Sophie
	public GameObject desktopImageSophie;
	public GameObject folderTrashSophie;

	//gameobjects Cass
	public GameObject desktopImageCass;
	public GameObject folderTrashCass;

	void Start () 
	{
		switchSessionCanvas.SetActive (false);
		blocNoteCanvas.SetActive (true);
		fenetrePoireCanvas.SetActive (false);
		browserCanvas.SetActive (false);
		elementsCommun.SetActive (true);

		facebookConnexionCanvas.SetActive (false);
		desktopImageCass.SetActive (false);	
		folderTrashCass.SetActive (false);
		folderTrashSophie.SetActive (false);

		facebookHeader.SetActive (false);

		gmailCanvas.SetActive (false);
		listContentMess.SetActive (true);
		listContentEcole.SetActive (false);
		listContentImportant.SetActive (false);
		listContentBrouillon.SetActive (false);
		listContentTrash.SetActive (false);
	}
}


