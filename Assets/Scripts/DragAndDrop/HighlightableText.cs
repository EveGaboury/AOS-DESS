using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HighlightableText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //Public
    [HideInInspector] public bool isOver = false;
	public static GameObject itemBeingDragged;
    public int objectID;

    //Privée
	private Color startingColor = Color.black, highlighted = Color.red;
	private GameObject thisIsIt;
	private string toBeHighlighted = "trololo";

	Vector2 startPosition;
	Transform startParent;

    void Start()
    {
		thisIsIt = this.gameObject;

		thisIsIt.GetComponent<Outline>().enabled = isOver;
		thisIsIt.GetComponent<Shadow>().enabled = isOver;
    }
		
	public void OnBeginDrag(PointerEventData eventData)
	{
		itemBeingDragged = this.gameObject;

		startPosition = transform.position;
		startParent = transform.parent;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		itemBeingDragged = null; 

		if (transform.parent == startParent) 
		{
			transform.position = startPosition;
		}
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
