using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;
using System;

public class Test : MonoBehaviour
{
	private int computing = 0;

	public void IsThisButtonWorking()
	{
		computing++;
		Debug.Log (computing);
	}

//	public GameObject[] bttnHolder;
//
//	private string[] oneTwoThreeViveLAlgerie = new string[] {"Alpha1","Alpha2","Alpha3"};
//
//	private Color currentColor, highlitedColor, normalColor;
//
//	KeyCode currentKey;
//
//	void Start()
//	{
//		highlitedColor = Color.red;
//		normalColor = Color.white;
//	}
//
//	void Update()
//	{
//		foreach (KeyCode pressedKey in System.Enum.GetValues(typeof(KeyCode))) 
//		{
//			if (Input.GetKeyDown(pressedKey))
//			{
//				currentKey = pressedKey;
//				currentColor = highlitedColor;
//				ManageButtonColor ();
//			}
//			else if (Input.GetKeyUp(pressedKey))
//			{
//				currentKey = pressedKey;
//				currentColor = normalColor;
//				ManageButtonColor ();
//			}
//		}
//	}
//
//	void ManageButtonColor() 
//	{
//		for (int i = 0; i < 3; i++) 
//		{
//			if (currentKey.ToString () == oneTwoThreeViveLAlgerie [i].ToString ()) 
//			{
//				bttnHolder [i].gameObject.GetComponent<Image> ().color = currentColor;
//			}
//			Debug.Log (oneTwoThreeViveLAlgerie [i]); 
//		}
//	}
} 