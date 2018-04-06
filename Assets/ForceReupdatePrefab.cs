using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceReupdatePrefab : MonoBehaviour {

	//public scrollRectPosition SR;
	public GameObject scriptManager;
	public GameObject scrollFacebook;


	void Start () {

		scriptManager = GameObject.Find ("ScriptManager");
		scrollFacebook = GameObject.Find ("ScrollbarFacebook");
	


	}

	public void OnEnable() {

		StartCoroutine(wait());
		Canvas.ForceUpdateCanvases();
	}


	IEnumerator wait () {
		yield return new WaitForSeconds (0.001f);
		scrollFacebook.GetComponent <Scrollbar> ().value -= 1f;
	}
}