using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ProfilDisplay : MonoBehaviour {

	public FacebookProfil F;

	public Image profilePicture;


	public TextMeshProUGUI name;
	public TextMeshProUGUI birthDate;
	public TextMeshProUGUI profession;


	public Image picture1;
	public Image picture2;
	public Image picture3;
	public Image picture4;
	public Image picture5;
	public Image picture6;
	public Image picture7;
	public Image picture8;
	public Image picture9;


	void Start () {

		profilePicture = F.profilePicture;

		name = F.name;
		birthDate = F.birthDate;
		profession = F.profession;

		picture1 = F.picture1;
		picture2 = F.picture2;
		picture3 = F.picture3;
		picture4 = F.picture4;
		picture5 = F.picture5;
		picture6 = F.picture6;
		picture7 = F.picture7;
		picture8 = F.picture8;
		picture9 = F.picture9;
	}

}
