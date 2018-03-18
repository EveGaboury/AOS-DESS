using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour 
{
	public List<GameObject> childObjects = new List<GameObject> ();

	void Start()
	{
		SearchAllButtonsInTheHierachy ();
	}

	void Update()
	{
		
	}

	void SearchAllButtonsInTheHierachy()
	{
		Transform[] allChildren = GetComponentsInChildren<Transform> (true);

		foreach (Transform child in allChildren) 
		{
			if (child.gameObject.tag == "CeciEstUnBouton")
			{
				childObjects.Add (child.gameObject);
				Debug.Log (child.name);
			}
		}
	}
}