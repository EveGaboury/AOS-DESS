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
	public Color startingColor = Color.black, highlighted = Color.red;
	private GameObject thisIsIt;

	TextMeshProUGUI textMeshProUGUI; 
   
	void Awake()
    {
		textMeshProUGUI = GetComponent<TextMeshProUGUI> ();
		textMeshProUGUI.outlineColor = startingColor;
		thisIsIt = this.gameObject;



    }
		
	void Update()
	{
		textMeshProUGUI.SetText(intialText);
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
	
		textMeshProUGUI.color = highlighted;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");

		textMeshProUGUI.color = startingColor;
    }
}
