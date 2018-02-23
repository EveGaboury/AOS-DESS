using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonBrowser : MonoBehaviour {


	//game state
	public GameObject sessionCass;
	public bool SoOpen = true;


	//boutton corbeille
	public Button trash;
	public GameObject windowCass;
	public GameObject windowSo; 


	//boutton Gmail
	public Button gmail;
	public GameObject gmailCass;
	public GameObject gmailSo;





	void Start () {

		Button btn = trash.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClickTrash);

		Button btn2 = gmail.GetComponent <Button> ();
		btn.onClick.AddListener (TaskOnClickGmail);

	}

	void Update () {


		//game state
		if (sessionCass.activeSelf == true) {
			SoOpen = false;
		}
		else
		{
			SoOpen = true;
		}
	}

	void TaskOnClickTrash () {

		if (SoOpen) {
			windowSo.SetActive (true);
		} else {
			windowCass.SetActive (true);
		}
	}

	void TaskOnClickGmail () {

		if (SoOpen) {
			gmailSo.SetActive (true);
		} else {
			gmailCass.SetActive (true);
		}
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
