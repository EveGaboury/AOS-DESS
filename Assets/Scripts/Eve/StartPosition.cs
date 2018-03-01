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


	//facebook
	public GameObject facebookConnexion;
	public GameObject facebookHeader;
	public GameObject passwordIncorrect;
	public GameObject facebookCanvas;

	//gmail
	public GameObject gmailCanvas;
	public GameObject listContentMess;
	public GameObject listContentBrouillon;
	public GameObject listContentTrash;

	// gameobjects Sophie
	public GameObject desktopImageSophie;
	public GameObject folderTrashSophie;
	public GameObject fenetreFolderSo;

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


		facebookConnexion.SetActive (false);
		facebookHeader.SetActive (false);
		passwordIncorrect.SetActive (false);
		facebookCanvas.SetActive (false);

		desktopImageCass.SetActive (false);	
		folderTrashCass.SetActive (false);
		folderTrashSophie.SetActive (false);
		fenetreFolderSo.SetActive (false);

		gmailCanvas.SetActive (false);
		listContentMess.SetActive (true);
		listContentBrouillon.SetActive (false);
		listContentTrash.SetActive (false);
		 
	}
}


