using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorSelector : MonoBehaviour 
{
	public Color textsStartColor;

	//TextMeshProUGUI textMeshProUGUI; 

	void Update () 
	{
		TextMeshProUGUI textMeshProUGUI = this.gameObject.GetComponent<TextMeshProUGUI> ();

		textMeshProUGUI.color = textsStartColor;
	}
}
