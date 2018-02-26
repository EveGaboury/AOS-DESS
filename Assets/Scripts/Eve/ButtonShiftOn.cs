using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonShiftOn : MonoBehaviour {


	public Button button;
	private bool shiftOn;
	public Image buttonColor;

	void Start () {


		Button btn = button.GetComponent<Button> ();
		//btn.onClick.AddListener (TaskOnClick);

	}


	void OnMouseDown () {

		if (button) {
			buttonColor.color = Color.gray;
			Debug.Log ("click");
		} else
		{
			buttonColor.color = Color.white;
			Debug.Log ("not");
		}
	}
}


//	void TaskOnClick (){


//		if (button.onClick)
//			shiftOn = !shiftOn;
//		else
			


//		shiftOn = !shiftOn;
//		if (shiftOn)
//			button.colors = Color.gray;
//		else
//			button.colors = Color.white;
		

