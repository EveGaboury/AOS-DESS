using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartPosition : MonoBehaviour {

//	public GameObject introduction;
//	public GameObject imageIntro;

	//gamobjects commun
	public GameObject desktopCanvas;
	public GameObject switchSessionCanvas;
	public GameObject blocNoteCanvas;
	public GameObject fenetrePoireCanvas;
	public GameObject elementsCommun;
	public GameObject gmailNotif;
	//public GameObject photoWindow;

	//Browser
	public GameObject browserCanvas;
	public GameObject notFound;
	public GameObject shortCut;
	public GameObject shortCutFacebook;
	public GameObject facebook_Image;

	//===================================================================================================================

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
	public GameObject mesAmisSo;
	public GameObject mesAmisCass;
	public GameObject buttonHeaderSophie;
	public GameObject notifSo;
	public GameObject notifCass;
	public GameObject toggleNotifSo;
	public GameObject toggleNotifCass;
	public GameObject shortCutSophieFB;
	public GameObject shortCutCassFB;
	public GameObject loading_Onglet;
	public GameObject onglet_text;
	public GameObject facebookimage;
	public GameObject animloading;

	public GameObject SoMessMarieEveMessenger;
	public GameObject SoMessCassMessenger;
	public GameObject SoMessYoMessenger;
	public GameObject SoMessPoMessenger;

	public GameObject CassMessPaMessenger;
	public GameObject CassMessAdrienMessenger;
	public GameObject CassMessHugoMessenger;
	public GameObject CassMessA1Messenger;
	public GameObject CassMessSophieMessenger;
	public GameObject CassMessA2Messenger;

	public GameObject messengerTemplate2;


	//facebook scriptable
	public GameObject profilCassScriptable;
	public GameObject profilSoScriptable;
	public GameObject profilAdrienScriptable;
	public GameObject profilYannScriptable;
	public GameObject profilHugoScriptable;
	public GameObject profilMarieEveScriptable;
	public GameObject profilFredScriptable;


	//facebook page newsfeed
	public GameObject pageNewFeedTemplate;
	public GameObject profilYann;
	public GameObject profilMarieEve2;
	public GameObject profilMarieEve1;
	public GameObject profilHugo2;
	public GameObject profilHugo1;
	public GameObject profilAdrien2;
	public GameObject profilAdrien1;
	public GameObject profilSophie;
	public GameObject profilCass;
	public GameObject profilFred;
	public GameObject postFinal;

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
	public GameObject fixCass;
	public GameObject fixSo;
	public GameObject dialogueMessenger;


	//facebook Amis
	public GameObject mesAmisTemplate;
	public GameObject mesAmisFix;

	//===================================================================================================================

	//gmail
	public GameObject gmailCanvas;
	public GameObject listContentBrouillon;
	public GameObject listContentTrash;
	public GameObject listContentMess;

	public GameObject C1corps;
	public GameObject C2corps;
	public GameObject C3corps;
	public GameObject C4corps;
	public GameObject C5corps;
	public GameObject C6corps;
	public GameObject CT2corps;
	public GameObject CB1corps;

	public GameObject C1info;
	public GameObject C2info;
	public GameObject C3info;
	public GameObject C4info;
	public GameObject C5info;
	public GameObject C6info;
	public GameObject CT2info;
	public GameObject CB1info;

	//===================================================================================================================

	// gameobjects Sophie
	public GameObject desktopImageSophie;
	public GameObject folderTrashSophie;
	public GameObject fenetreFolderSo;
	public GameObject memoWord;
	public GameObject itunes;
	public GameObject sessionSo;

	//gameobjects Cass
	public GameObject folderTrashCass;
	public GameObject fenetreFolderCass;
	public GameObject sessionCass;

	//===================================================================================================================

	//avis deces
	public GameObject avisDeces;
	public GameObject shortCutDeces;

	//Introduction.
	public GameObject leDevoir;
	public GameObject voile;

	//EndGame

	public GameObject Fin;

	//help
	public GameObject windowHelp;



	void Start () 
	{
		//introduction.SetActive (true);

		switchSessionCanvas.SetActive (false);
		blocNoteCanvas.SetActive (true);
		fenetrePoireCanvas.SetActive (false);
		elementsCommun.SetActive (true);
		gmailNotif.SetActive (true);
		//photoWindow.SetActive (false);

		shortCutFacebook.SetActive (false);


		//browser mis en true pour l'intro
		browserCanvas.SetActive (true);


		notFound.SetActive (false);
		shortCut.SetActive (false);
		pageProfilTemplate.SetActive (false);
		newsFeedTemplate.SetActive (false);
		rechercheTemplate.SetActive (false);
		amisTemplate.SetActive (false);
		wrongPassword.SetActive (false);
		NFCass.SetActive (false);
		buttonHeaderSophie.SetActive (false);
		notifSo.SetActive (false);
		notifCass.SetActive (false);
		loading_Onglet.SetActive (false);

		pageNewFeedTemplate.SetActive (false);
		profilYann.SetActive (false);
		profilMarieEve2.SetActive (false);
		profilMarieEve1.SetActive (false);
		profilHugo2.SetActive (false);
		profilHugo1.SetActive (false);
		profilAdrien2.SetActive (false);
		profilAdrien1.SetActive (false);
		profilSophie.SetActive (false);
		profilCass.SetActive (false);
		profilFred.SetActive (false);

		facebookConnInPage.SetActive (false);
		shortCutSophieFB.SetActive (false);
		shortCutCassFB.SetActive (false);

		questionOne.SetActive (false);
		question2.SetActive (false);
		fauxText.SetActive (false);
		vraiText.SetActive (false);
		question3.SetActive (false);
		bouttonfinal.SetActive (false);

		messengerTemplate.SetActive (false);
		messengerFix.SetActive (false);
		fixCass.SetActive (false);
		fixSo.SetActive (false);

		mesAmisTemplate.SetActive (false);
		mesAmisFix.SetActive (false);

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
		memoWord.SetActive (false);
		itunes.SetActive (false); 

		gmailCanvas.SetActive (false);
		listContentMess.SetActive (true);
		listContentTrash.SetActive (false);
		listContentBrouillon.SetActive (false);

		avisDeces.SetActive (false);
		shortCutDeces.SetActive (false);

		Fin.SetActive (false);

		leDevoir.SetActive (true);
		voile.SetActive (true);


		//windowHelp.SetActive (false);

	}




}


