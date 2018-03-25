﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NewData : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
//	public int objID;

	public GameObject resultatBlocNotes;

	Color currentColorValue, highLightedColor = Color.yellow, startingColor = Color.white;

	GameObject prefab, parentToBe;

	string startingText, currentTextValue;

	float currentAlphaValue;

	void Start()
	{
		prefab = this.gameObject;
		startingText = prefab.GetComponentInChildren<TMP_Text> ().text;
		parentToBe = GameObject.Find ("InventorySlot");
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (resultatBlocNotes.GetComponent<DataPrefab> ().animClipIsPlaying == false) 
		{
			currentTextValue = "<b>" + startingText + "</b>";
			currentAlphaValue = 255f;
			currentColorValue = highLightedColor;
			ManageColorChange ();
		}
	}

	public void OnPointerExit (PointerEventData eventData)
	{	
		currentTextValue = startingText;
		currentAlphaValue = 0f;
		currentColorValue = startingColor;
		ManageColorChange ();
	}

	void ManageColorChange()
	{
		prefab.GetComponentInChildren<TMP_Text> ().text = currentTextValue;

		prefab.GetComponent<Image> ().CrossFadeAlpha (currentAlphaValue,0,true);

		prefab.GetComponent<Image> ().color = currentColorValue;
	}

	public void StartAnimation()
	{
		resultatBlocNotes.GetComponent<Animator> ().SetBool ("onClick", true);

		resultatBlocNotes.GetComponent<DataPrefab> ().animClipIsPlaying = true;

		resultatBlocNotes.GetComponent<Transform> ().SetParent (parentToBe.transform);

		resultatBlocNotes.GetComponent<Transform> ().localScale = new Vector2(1.0f, 1.0f);

		this.gameObject.GetComponent<Button> ().enabled = false;

//		GameObject newDataInstance = Instantiate (prefab, Vector2.zero, Quaternion.identity) as GameObject;
//
//		newDataInstance.GetComponent<Transform> ().SetParent (parentToBe.transform);
//
//		newDataInstance.GetComponent<Transform> ().localScale = new Vector2(.5f, .5f);
//
//		newDataInstance.GetComponent<Image> ().enabled = false;
//
//		Debug.Log ("Hello World!");
	}
}