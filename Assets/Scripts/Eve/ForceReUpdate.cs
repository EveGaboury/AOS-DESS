using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceReUpdate : MonoBehaviour {

	//public scrollRectPosition SR;
	public GameObject scriptManager;
	public ScrollRect scrollFacebook;

	public void OnEnable() {

		StartCoroutine(wait());
		Canvas.ForceUpdateCanvases();
	}
		
	IEnumerator wait () 
	{
		yield return new WaitForSeconds (0.001f);
		scrollFacebook.verticalNormalizedPosition = 0f;	
	}
}