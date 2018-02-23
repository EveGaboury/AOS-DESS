using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TrashWindow : MonoBehaviour {

	public Button trash;
	public GameObject sessionCass;
	public GameObject windowCass;
	public GameObject windowSo; 

	public bool SoOpen = true;



	void Start () {

		Button btn = trash.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClick);

	}

	void Update () {
		
		if (sessionCass.activeSelf == true) {
			SoOpen = false;
		}
		else
		{
			SoOpen = true;
		}
	}

	void TaskOnClick () {

		if (SoOpen) {
			windowSo.SetActive (true);
		} else {
			windowCass.SetActive (true);
		}

		Debug.Log ("le bouton marche");

	

	}
}








//	void Update (){
//
//		if (CassClosed) {
//			sessionCass.SetActive (false);
//			CassClosed = !CassClosed;
//		}
//
//	}
//	
//
//	void TaskOnClick () 
//	{
//
//		if (CassClosed) {
//			windowSo.SetActive (true);
//		} else
//			windowCass.SetActive (true);
//	}
//}
