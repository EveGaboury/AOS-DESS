using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartPosition : MonoBehaviour {

	//gamobjects commun
	public GameObject switchSessionCanvas;
	public GameObject blocNoteCanvas;
	public GameObject fenetrePoireCanvas;
	public GameObject elementsCommun;

	//Browser
	public GameObject browserCanvas;
	public GameObject notFound;
	public GameObject shortCut;


	//facebook
	public GameObject facebookConnexion;
	public GameObject facebookHeader;
	public GameObject passwordIncorrect;
	public GameObject facebookCanvas;
	public GameObject pageProfilTemplate;
	public GameObject facebookInfoScriptable;
	public GameObject iconProfilCass;


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

	public GameObject folderTrashCass;
	public GameObject fenetreFolderCass;
	public GameObject sessionCass;

	void Start () 
	{
		switchSessionCanvas.SetActive (false);
		blocNoteCanvas.SetActive (true);
		fenetrePoireCanvas.SetActive (false);
		elementsCommun.SetActive (true);

		browserCanvas.SetActive (false);
		notFound.SetActive (false);
		shortCut.SetActive (false);
		pageProfilTemplate.SetActive (false);


		facebookConnexion.SetActive (false);
		facebookHeader.SetActive (false);
		passwordIncorrect.SetActive (false);
		facebookCanvas.SetActive (false);
		facebookInfoScriptable.SetActive (false);
		iconProfilCass.SetActive (false);


		folderTrashCass.SetActive (false);
		fenetreFolderCass.SetActive (false);
		sessionCass.SetActive (false);

		folderTrashSophie.SetActive (false);
		fenetreFolderSo.SetActive (false);

		gmailCanvas.SetActive (false);
		listContentMess.SetActive (true);
		listContentBrouillon.SetActive (false);
		listContentTrash.SetActive (false);
		 
	}
}


