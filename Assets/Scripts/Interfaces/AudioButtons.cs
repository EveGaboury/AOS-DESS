using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioButtons : MonoBehaviour 
{
	public List<GameObject> childObjectsContainingButtons = new List<GameObject>(), parentObjects = new List<GameObject>();

	string importantParent = "GmailCanvas 1";

	void Start()
	{
		SearchAllButtonsInTheHierarchy ();
		SortButtonsByParent ();
	}

	void SearchAllButtonsInTheHierarchy()
	{
		Transform[] allChildren = GetComponentsInChildren<Transform> (true);

		foreach (Transform child in allChildren) 
		{
			if (child.gameObject.GetComponent<Button> ()) 
			{
				childObjectsContainingButtons.Add (child.gameObject);
				//				Debug.Log ("Ceci est un boutton: " + child.name);
			} 
			else 
			{
				parentObjects.Add (child.gameObject);
				//				Debug.Log ("Ceci n'est pas un boutton: " + child.name);
			}
		}
	}

	void SortButtonsByParent()
	{
		for (int i = 0; i < parentObjects.Count; i++)
		{

			if (parentObjects[i].gameObject.name == importantParent) 
			{
				//				parentObjects [i].gameObject.tag = "Gmail";

				if (parentObjects[i].gameObject.GetComponentsInChildren<Transform>(true) != null) 
				{
					for (int j = 0; j < childObjectsContainingButtons.Count; j++) 
					{
						if (childObjectsContainingButtons[j].gameObject != null) 
						{
							childObjectsContainingButtons [j].gameObject.tag = "Gmail";
//							Debug.Log ("trololo");
						}
					}
				}

				//				Transform[] allChildren = GetComponentsInChildren<Transform> (true);
				//
				//				foreach (Transform child in allChildren) 
				//				{
				//					if (allChildren[i].gameObject.name == childObjectsContainingButtons[i].gameObject.name) 
				//					{
				//						Debug.Log ("trololo");
				//					}
				//				}
			}
		}

		//		for (int i = 0; i < childObjectsContainingButtons.Count; i++)
		//		{
		//			Debug.Log(childObjectsContainingButtons [i].gameObject.GetComponentsInParent<Transform> ().name);
		//		}

		//		Transform[] allParents = GetComponentsInParent<Transform> (true);
		//
		//		foreach (Transform parent in allParents) 
		//		{
		//			if (parent.gameObject != null) 
		//			{
		//				Debug.Log ("troolololole: " + parent.name);
		//			}
		//		}

		//		for (int i = 0; i < childObjectsContainingButtons.Count; i++) 
		//		{
		//			Debug.Log ("Le parent de " + childObjectsContainingButtons[i].gameObject.name + " est: " + childObjectsContainingButtons[i].gameObject.transform.parent.name);
		//
		//			if (childObjectsContainingButtons[i].gameObject.transform.parent.name == "SessionSophie") 
		//			{
		//				Debug.Log (childObjectsContainingButtons[i].gameObject.name);
		//			}
		//		}
	}
}
