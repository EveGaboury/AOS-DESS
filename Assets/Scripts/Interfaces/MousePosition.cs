using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePosition : MonoBehaviour 
{
	Vector2 hotSpot = Vector2.zero;

	CursorMode cursorMode = CursorMode.Auto;

	public void StartThatCoroutine()
	{
		StartCoroutine (Testing());
	}

	IEnumerator Testing() 
	{
		//Cursor.SetCursor (curTxt_Clicked, hotSpot, cursorMode);

		yield return new WaitForSeconds (0.25f);

		Cursor.SetCursor (null, hotSpot, cursorMode);
	}
}