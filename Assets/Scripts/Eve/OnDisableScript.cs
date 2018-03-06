using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class OnDisableScript : MonoBehaviour {


	public ButtonManager BM;

	void OnDisable()
	{
		Debug.Log ("cllleaaarrr");
		BM.ClearContent ();
	}
}
