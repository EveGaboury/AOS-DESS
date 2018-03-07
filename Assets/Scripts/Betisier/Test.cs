using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class Test : MonoBehaviour
{
	void Start()
	{
		this.gameObject.GetComponent<TextMeshProUGUI> ().text = "";

		Debug.Log ("Hello World! from: " + gameObject.name + ", children of: " + transform.parent);
	}
} 