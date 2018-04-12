﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class SoundClickScript : MonoBehaviour {  	public AudioSource audioSourceClick;    	//list sound mouse clikcs and typing 	public AudioClip[] soundClickList; 	public AudioClip[] soundtypingList;   	// Use this for initialization 	void Start () {  	}   	void Awake () 	{ 		audioSourceClick = this.gameObject.GetComponent<AudioSource> (); 	}   	void Update ()  	{ 		if (Input.GetMouseButtonDown (0)) 		{ 			audioSourceClick.clip = soundClickList [Random.Range (0,soundClickList.Length)]; 			audioSourceClick.PlayOneShot (audioSourceClick.clip); 			//Debug.Log ("son de mouse"); 		}  		if (Input.anyKeyDown) 		{ 			if (Input.GetMouseButton (0) || Input.GetMouseButton (1) || Input.GetMouseButton (2) ) 			{ 				return; 			} 			audioSourceClick.clip = soundtypingList [Random.Range (0,soundtypingList.Length)]; 			audioSourceClick.PlayOneShot (audioSourceClick.clip); 			Debug.Log ("son de clavier"); 		} 	}   }  