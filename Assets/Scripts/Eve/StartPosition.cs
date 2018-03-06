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
	public GameObject facebookConnInPage;
	public GameObject facebookHeader;
	public GameObject facebookCanvas;
	public GameObject pageProfilTemplate;
	public GameObject facebookInfoScriptable;
	public GameObject buttonCass;
	public GameObject newsFeedTemplate;
	public GameObject passwordTemplate;
	public GameObject wrongPassword;
	public GameObject NFCass;


	//facebook mot de passe oublie
	public GameObject questionOne;
	public GameObject fauxText;
	public GameObject vraiText;


	//facebook messenger
	public GameObject messengerTemplate;

	//facebook Amis
	public GameObject mesAmisTemplate;


	//gmail
	public GameObject gmailCanvas;


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
		newsFeedTemplate.SetActive (false);
		wrongPassword.SetActive (false);
		NFCass.SetActive (false);

		questionOne.SetActive (false);
		fauxText.SetActive (false);
		vraiText.SetActive (false);

		messengerTemplate.SetActive (false);

		mesAmisTemplate.SetActive (false);

		facebookConnexion.SetActive (false);

		facebookHeader.SetActive (false);
		facebookCanvas.SetActive (false);
		facebookInfoScriptable.SetActive (false);
		buttonCass.SetActive (false);
		passwordTemplate.SetActive (false);


		folderTrashCass.SetActive (false);
		fenetreFolderCass.SetActive (false);
		sessionCass.SetActive (false);

		folderTrashSophie.SetActive (false);
		fenetreFolderSo.SetActive (false);

		gmailCanvas.SetActive (false);

	}
}


