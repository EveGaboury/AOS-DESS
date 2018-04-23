using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;


public class HelpScript : MonoBehaviour {




	public TextMeshProUGUI TextAide;


	public Button boutonConnexionTL;
	public Button boutonDataTL;
	public Button boutonHacking;
	public Button boutonPosting;

	private bool ConnextionTLDone;

	// Use this for initialization
	void Start () 

	{

		TextMeshProUGUI TextAide = GetComponent <TextMeshProUGUI>();
		TextAide.text = ("Bonjour. Vous pouvez toujours aller voir vos courriels. Certaines informations peuvent être importantes à lire et à receuillir.");

		boutonConnexionTL.GetComponent <Button> ();
		boutonConnexionTL.onClick.AddListener (TaskOnConnexionTL);

	
		boutonDataTL.GetComponent <Button> ();
		boutonDataTL.onClick.AddListener (TaskOnDataTL);
	
		 
		boutonHacking.GetComponent <Button> ();
		boutonHacking.onClick.AddListener (TaskOnHacking);

		//Button boutonPosting = 
		boutonPosting.GetComponent <Button> ();
		boutonPosting.onClick.AddListener (TaskOnPosting);



		TextAide.text = ("Bonjour. Vous pouvez toujours aller voir vos courriels. Certaines informations peuvent être importantes à lire et à receuillir.");


	}


	public void TaskOnDataTL () 
	{
		TextAide.text = ("Pour accéder à TonLivre, vous avez besoin d'une adresse courriel et d'un mot de passe. Si vous avez oublié votre mot de passe, il existe un moyen pour récupérer votre compte tout de même. Une série de questions de confidentalité vous sera posée.");
	}


	public void TaskOnConnexionTL () 
	{

		if (ConnextionTLDone == false) 
		{

		TextAide.text = ("TonLivre est une mine d'or d'informations. N'hésitez pas à aller observer des profils et chercher des personnes dans le moteur de recherche inclus dans TonLivre. ");

		ConnextionTLDone = true;
		}
	
	}

	public void TaskOnHacking () 
	{
		TextAide.text = ("Pour publier un post sur TonLivre, appuyez sur l'icone de votre portrait pour accéder à votre fil d'actualité.");
	}

	public void TaskOnPosting () 
	{
		TextAide.text = ("Maintenant que vous êtes sur son compte, pourquoi pas fouiller un peu ?");
	}
}



