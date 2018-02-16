using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScaleButton : MonoBehaviour {

	public Renderer render;

	void Start () 
	{
		render = GetComponent <Renderer> ();
	}

	void OnMouseOver()
	{
		Debug.Log ("the mouse is over" + render.name); 
	}

	void OnMouseExit ()
	{
		Debug.Log ("the mouse is no longer on" + render.name);

	}
}
