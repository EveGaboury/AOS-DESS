using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceReUpdate : MonoBehaviour {

	public scrollRectPosition SR;



	void OnEnable() {
		
		Canvas.ForceUpdateCanvases();
		SR.InvertStart ();

	}
}