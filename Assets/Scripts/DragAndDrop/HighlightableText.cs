using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class HighlightableText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //Public
    //[HideInInspector] public bool isOver = false;

	public string intialText;
    
	//Privée
	private Color startingColor = Color.black, highlighted = Color.red;
	private GameObject thisIsIt;

	TextMeshProUGUI textMeshProUGUI; 
    
	void Start()
    {
		thisIsIt = this.gameObject;

		textMeshProUGUI = GetComponent<TextMeshProUGUI> ();
		textMeshProUGUI.outlineColor = Color.black;

    }
		
	void Update()
	{
		textMeshProUGUI.SetText(intialText);
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
	
		textMeshProUGUI.color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");

		textMeshProUGUI.color = Color.black;
    }
}
