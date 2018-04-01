using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceReUpdate : MonoBehaviour {

	public scrollRectPosition SR;

	void OnEnable() {



		StartCoroutine(wait());
		Canvas.ForceUpdateCanvases();

	}


	IEnumerator wait () {
		yield return new WaitForSeconds (0.001f);
		SR.scrollFacebook.verticalNormalizedPosition = 0f;	



	}
}