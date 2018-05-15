using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HeureScript : MonoBehaviour
{
	public TextMeshProUGUI TextHeure;

	private float startTime = 0;

	void Start () 
	{
		startTime = Time.deltaTime;
	}

	void Update () 
	{
		if (SceneManager.GetActiveScene ().name == "Scene_final") 
		{
			float t = Time.time + startTime;

			int minutes = (int) (t / 60);

			string str = minutes.ToString("00");

			TextMeshProUGUI TextAide = GetComponent <TextMeshProUGUI>();

			TextAide.text = ("11:" + str);
		}
		else if (SceneManager.GetActiveScene ().name == "Scene_Intro") 
		{
			startTime = 0;
		}
	}
}