using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine;


public class SwitchBetweenInputFields : MonoBehaviour 
{
	public List<GameObject> listOfInputFields = new List<GameObject>();

	void Update ()
	{
		GoToNextInputField ();
	}

	void GoToNextInputField()
	{
		for (int i = 0; i < listOfInputFields.Count; i++) 
		{
			if (EventSystem.current.currentSelectedGameObject == listOfInputFields[i] && Input.GetKeyDown(KeyCode.Tab)) 
			{
				EventSystem.current.SetSelectedGameObject(listOfInputFields [(i + 1) % listOfInputFields.Count]);
				//Debug.Log ("From Test.cs, the current EventSystem.current.currentSelectedGameObject: " + EventSystem.current.currentSelectedGameObject);
			}
		}
	}
}
