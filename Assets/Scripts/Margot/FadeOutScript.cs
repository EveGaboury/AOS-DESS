﻿using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.UI;  public class FadeOutScript : MonoBehaviour {  	public Image voile1; 	public Image voile2; 	public Image voile3; 	public Image voile4;    	// Use this for initialization 	void Start ()  	{ 		 	 		///rend = GetComponent<SpriteRenderer> (); 		//Color c = rend.material.color; 		//	c.a = 0f; 		//rend.material.color = c;  	}     	IEnumerator FadeOut () 	{  		for (float i = 1; i >= 0; i -= Time.deltaTime) 		{  			voile1.color = new Color(1, 1, 1, i); 			voile2.color = new Color(1, 1, 1, i); 			voile3.color = new Color(1, 1, 1, i); 			voile4.color = new Color(1, 1, 1, i);   			yield return null; 		}    		//for (float f = 1f; f >= -0.05f; f -= 0.05f)  	//	{ 	//		Color c = rend.material.color; 			//c.a = f; 		//	rend.material.color = c; 		//	yield return new WaitForSeconds (0.05f);   		//} 	}  	public void startFading ()  	{ 		StartCoroutine ("FadeOut");  	}   }    