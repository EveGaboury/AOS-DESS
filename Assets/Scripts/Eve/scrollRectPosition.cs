﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class scrollRectPosition : MonoBehaviour {


	public ScrollRect scrollFacebook;
	public Scrollbar scrollBarFacebook;

	// Use this for initialization
	public void Start () {


		scrollFacebook.verticalNormalizedPosition = 1f;	
	}

	public void InvertStart () {
		
		scrollFacebook.verticalNormalizedPosition = 0f;	

	}
}
