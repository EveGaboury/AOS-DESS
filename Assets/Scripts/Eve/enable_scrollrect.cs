using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable_scrollrect : MonoBehaviour {

	public scrollRectPosition SR;

	// Use this for initialization
	void OnEnable () {

		Debug.Log ("allo");
		SR.InvertScroll ();

	}
}