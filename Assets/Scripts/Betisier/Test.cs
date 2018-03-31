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
	private string[] oneTwoThreeViveLAlgerie = new string[] {"Alpha1","Alpha2","Alpha3"};

	void Update()
	{
		foreach (KeyCode pressedKey in System.Enum.GetValues(typeof(KeyCode))) 
		{
			if (Input.GetKeyDown(pressedKey))
			{
				for (int i = 0; i < oneTwoThreeViveLAlgerie.Length; i++) 
				{
					if (pressedKey.ToString() == oneTwoThreeViveLAlgerie[i].ToString()) 
					{
						Debug.Log (oneTwoThreeViveLAlgerie[i]);
					}
				}
			}
		}
	}
} 