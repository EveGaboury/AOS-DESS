using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HighlightableText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //Public
    [HideInInspector] public bool isOver = false;
	public string intialText;
    //Privée
	private Color startingColor = Color.black, highlighted = Color.red;
	private GameObject thisIsIt;

    void Start()
    {
		thisIsIt = this.gameObject;

		thisIsIt.GetComponent<Outline>().enabled = isOver;
		thisIsIt.GetComponent<Shadow>().enabled = isOver;
    }
		
	void Update()
	{
		thisIsIt.GetComponent<Text> ().text = intialText;
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
        isOver = true;

		thisIsIt.GetComponent<Outline>().enabled = isOver;
		thisIsIt.GetComponent<Text> ().color = highlighted;
		thisIsIt.GetComponent<Shadow>().enabled = isOver;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
        isOver = false;

		thisIsIt.GetComponent<Outline>().enabled = isOver;
		thisIsIt.GetComponent<Text> ().color = startingColor;
		thisIsIt.GetComponent<Shadow>().enabled = isOver;
    }
}
