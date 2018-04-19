using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HeureScript : MonoBehaviour {



	public TextMeshProUGUI TextHeure;

	private float startTime = 0;


	// Use this for initialization
	void Start () 
	{

		startTime = Time.time;



		
	}
	
	// Update is called once per frame
	void Update () 
	{

		float t = Time.time + startTime;


		int minutes = (int) (t / 60);


		string str = minutes.ToString("00");

		TextMeshProUGUI TextAide = GetComponent <TextMeshProUGUI>();
		TextAide.text = ("11:" + str);
	}
}
