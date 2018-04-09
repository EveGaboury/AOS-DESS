﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StatutConnection : MonoBehaviour {


	public Image statutConnection;
	public Sprite boutonVert;
	public Button marieEve;

	public GameObject dialogBox;

	public RectTransform viewPort;

	public bool vertOuvert = true;

	private Vector2 changedState2, initialState2;
	private Vector3 changedState3, initialState3;
			

	void Start () 
	{

		changedState2 = new Vector2 (1363f, 598f);
		changedState3 = new Vector3 (-16f, 105f, 0f);

		initialState2 = new Vector2 (1363f,812f);
		initialState3 = new Vector3 (-16f,-0.34f,0f);
	}

	public void OnClick_Messenger () 
	{
		if (statutConnection.sprite.name == "bouton_vert") 
		{
			Debug.Log ("ok c'est chill");
			dialogBox.SetActive (true);
			viewPort.sizeDelta = changedState2;
			viewPort.localPosition = changedState3;
		}
	}

	public void VertOuvert ()
	{
		if (vertOuvert) {
			OnClick_Messenger ();
		} else {
			viewPort.sizeDelta = initialState2;
			viewPort.localPosition = initialState3;
		}
	}

	public void InitialState () 
	{
		viewPort.sizeDelta = initialState2;
		viewPort.localPosition = initialState3;
		dialogBox.SetActive (false);
	}
}