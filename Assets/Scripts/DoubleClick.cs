using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class DoubleClick : MonoBehaviour {


	public Button folder;

	private int counter;
	public float clickTimer = .5f;

	public GameObject window; 


	void Start () 
	{
		folder.onClick.AddListener (buttonListener);

	}

	private void buttonListener ()
	{
		counter++;
		if (counter == 1) 
		{
			StartCoroutine ("doubleClickEvent");
		}
	}

	IEnumerator doubleClickEvent ()
	{
		yield return new WaitForSeconds (clickTimer);
		if (counter > 1) 
		{
			Debug.Log ("double click");
			window.SetActive (true);
		}

		yield return new WaitForSeconds (.05f);
		counter = 0;

	}

}
