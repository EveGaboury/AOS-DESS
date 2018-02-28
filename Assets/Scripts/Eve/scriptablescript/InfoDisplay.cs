using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoDisplay : MonoBehaviour {

	public Gmail gmail; 

	public TextMeshProUGUI name;
	public TextMeshProUGUI objet;
	public TextMeshProUGUI infoMessage;
	public TextMeshProUGUI corpsMessage;


	void Start () {

		name.text = gmail.name;
		objet.text = gmail.objet;
		infoMessage.text = gmail.infoMessage;
		corpsMessage.text = gmail.corpsMessage;

		
	}

}
