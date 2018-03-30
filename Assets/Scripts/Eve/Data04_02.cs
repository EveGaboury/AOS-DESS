using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data04_02 : MonoBehaviour {

	public GameObject J04_03;


	public GameObject parentToBe;

	// Use this for initialization
	void Start () {

	parentToBe = GameObject.Find ("Content_InventorySlot");

		StartCoroutine(wait());

	}



	 IEnumerator wait () {

		yield return new WaitForSeconds (2.7f);
		J04_03.SetActive (true);
		J04_03.GetComponent<Transform> ().SetParent (parentToBe.transform);
	}
}
