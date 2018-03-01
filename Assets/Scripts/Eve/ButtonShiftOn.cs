using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonShiftOn : MonoBehaviour 
{
	public GameObject[] btn;
	public bool[] isActive;
	//public Color highLightedColor;
	//private Color startingColor = Color.white;

	void Start()
	{
//		Button testButton = Selectable.Transition.
//
//		for (int i = 0; i < 5; i++) 
//		{
////			Debug.Log ("trorlolooloeoeleodods");
////			btn [i].GetComponent<Image> ().color = Color.white;
////			isActive[i] = false;
//		}
	}	

	void Update()
	{

		if (btn[0].GetComponent<Toggle>().isOn == true) 
		{
			Debug.Log ("la valeur du toggle de BoiteMessagerie est vraie");
		}
		else if(btn[0].GetComponent<Toggle>().isOn == false)
		{
			Debug.Log ("la valeur du toggle de BoiteMessagerie est fausse");
		}

//		BoiteMessagerie ();
//		Brouillon();
//		Ecole ();	
//		Important ();
//		Corbeille ();
	}

	public void BoiteMessagerie()
	{	
		btn[0].GetComponent<Image>().color = Color.cyan;
//		isActive [0] = true;
//
//		if (isActive [0] == true) 
//		{
//			btn[0].GetComponent<Image>().color = Color.cyan;
//			isActive [1] = false;
//			isActive[2] = false;
//			isActive[3] = false;
//			isActive[4] = false;
//		}
	}

	public void Brouillon()
	{
		btn [1].GetComponent<Image> ().color = Color.green;

//		isActive [1] = true;

//		if (isActive [1] == true) 
//		{
//			btn [1].GetComponent<Image> ().color = Color.green;
//			isActive [0] = false;
//			//btn[0].GetComponent<Image>().color = Color.white;
//			isActive[2] = false;
//			isActive[3] = false;
//			isActive[4] = false;
//		}
	}
//
	public void Ecole()
	{
		btn[2].GetComponent<Image> ().color = Color.red;
//		isActive [2] = true;
//
//		if (isActive [2] == true) 
//		{
//			
//			isActive [0] = false;
//			isActive[1] = false;
//			isActive[3] = false;
//			isActive[4] = false;
//		}
	}

	public void Important()
	{
		btn[3].GetComponent<Image> ().color = Color.blue;
//		isActive [3] = true;
//
//
//		if (isActive [3] == true) 
//		{
//			
//			isActive [0] = false;
//			isActive[1] = false;
//			isActive[2] = false;
//			isActive[4] = false;
//		}
	}

	public void Corbeille()
	{
		btn[4].GetComponent<Image> ().color = Color.grey;

//		isActive [4] = true;
//
//		if (isActive [4] == true) 
//		{
//			
//			isActive[0] = false;
//			isActive[1] = false;
//			isActive[2] = false;
//			isActive[3] = false;
//		}
	}



//	void ButtonColor()
//	{
//		ColorBlock cb = btn [0].colors;
//		cb.pressedColor = Color.red;
//		btn [0].colors = cb;
//	}
}
	
//btn = GetComponents<Button> ();



/*
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
*/