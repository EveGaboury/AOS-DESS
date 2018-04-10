using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
	void Start()
	{
		AudioSource[] chms = FindObjectsOfType (typeof(AudioSource)) as AudioSource[]; 

		for (int i = 0; i < chms.Length; i++) 
		{
			Debug.Log (chms[i].gameObject.name);
		}


//		GameObject[] testing = GameObject.FindObjectsOfType(typeof(AudioSource)) as GameObject;
//
//		for (int i = 0; i < testing.Length; i++) 
//		{
//			print (testing[i]);
//		}

		//Transform[] localTransform = 
	}
} 