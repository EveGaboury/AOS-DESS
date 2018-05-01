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
	public TextMeshProUGUI birthplace;
	public TextMeshProUGUI lifeplace;


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

		profilePicture.sprite = F.profilePicture;

		name.text = F.name;
		birthDate.text = F.birthDate;
		profession.text = F.profession;
		birthplace.text = F.birthplace;
		lifeplace.text = F.lifeplace;

		picture1.sprite = F.picture1;
		picture2.sprite = F.picture2;
		picture3.sprite = F.picture3;
		picture4.sprite = F.picture4;
		picture5.sprite = F.picture5;
		picture6.sprite = F.picture6;
		picture7.sprite = F.picture7;
		picture8.sprite = F.picture8;
		picture9.sprite = F.picture9;
	}

}
