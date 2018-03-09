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
	public GameObject buttonHeaderCass;
	public GameObject newsFeedTemplate;
	public GameObject passwordTemplate;
	public GameObject rechercheTemplate;
	public GameObject amisTemplate;
	public GameObject wrongPassword;
	public GameObject NFCass;
	public GameObject NFSo;




	//facebook mot de passe oublie
	public GameObject questionOne;
	public GameObject question2;
	public GameObject fauxText;
	public GameObject vraiText;
	public GameObject question3;
	public GameObject bouttonfinal;


	//facebook messenger
	public GameObject messengerTemplate;
	public GameObject messengerFix;

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
		rechercheTemplate.SetActive (false);
		amisTemplate.SetActive (false);
		wrongPassword.SetActive (false);
		NFCass.SetActive (false);

		questionOne.SetActive (false);
		question2.SetActive (false);
		fauxText.SetActive (false);
		vraiText.SetActive (false);
		question3.SetActive (false);
		bouttonfinal.SetActive (false);

		messengerTemplate.SetActive (false);
		messengerFix.SetActive (false);

		mesAmisTemplate.SetActive (false);

		facebookConnexion.SetActive (false);

		facebookHeader.SetActive (false);
		facebookCanvas.SetActive (false);
		facebookInfoScriptable.SetActive (false);
		buttonHeaderCass.SetActive (false);
		passwordTemplate.SetActive (false);


		folderTrashCass.SetActive (false);
		fenetreFolderCass.SetActive (false);
		sessionCass.SetActive (false);

		folderTrashSophie.SetActive (false);
		fenetreFolderSo.SetActive (false);

		gmailCanvas.SetActive (false);

	}
}


