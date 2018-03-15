using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class Test : MonoBehaviour
{
	public List<GameObject> testingListed = new List<GameObject>();

	void Start()
	{
		Component[] broDog;

		broDog = GetComponentsInChildren (typeof(Transform/*Button*/));

		if (broDog != null)
		{
			foreach (Transform/*Button*/ item in broDog) 
			{
				testingListed.Add (item.gameObject);

				for (int i = 0; i < testingListed.Count; i++) 
				{
					if (testingListed[i].GetComponent<Button>() == true) 
					{

						Debug.Log (testingListed[i].name);
					}

					if (testingListed[i].gameObject.GetComponentInChildren<Button>() == true) 
					{
						Debug.Log (testingListed[i].name);
					}
//					Debug.Log (testingListed.Count);

//					Debug.Log ("Le boutton: " + testingListed[i].name + ", dont le parent est: " + testingListed[i].gameObject.GetComponentInParent<Transform>().transform.parent.name);
				}
			}
		}
	}
} 