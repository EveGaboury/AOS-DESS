using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System.Linq;


public class ObjectDraggableSlot : MonoBehaviour, IDropHandler
{
	public string[] newText;
	public int[] checkID;

	//[HideInInspector] public float totalHeight;

	List<Transform> list = new List<Transform>();

	public void OnDrop (PointerEventData eventData)
	{
		DraggableObject tri = eventData.pointerDrag.GetComponent<DraggableObject> ();

		for (int i = 0; i < checkID.Length; i++) 
		{
			if (tri != null) 
			{
				if (tri.objectID == checkID [i]) 
				{
					tri.transform.SetParent(transform);
					if (tri.GetComponent<Image> ()) 
					{
						Debug.Log ("Une image a été ajoutée au bloc notes");
					} 
					else 
					{
						tri.GetComponent<HighlightableText> ().intialText = newText [i];
					}
				}
			}
		}
	}

	void OnTransformChildrenChanged()
	{
//		foreach (Transform t in transform) 
//		{
//			list.Add (t.gameObject);
//			//Debug.Log (list.Where(h => h.totalHeight == t.gameObject.GetComponent<RectTransform>().rect.height).Sum(h => h.ToString()));
////			float sum = t.gameObject.GetComponent<RectTransform> ().rect.height;
////			while (n != 0)
////			{
////				sum += n % 10;
////				n /=10;
////			}
//
//			//int result = list.FindAll (t.gameObject.GetComponent<RectTransform> ()).Sum (c => c - '0');
//
////			if (list.Sum(t.gameObject.GetComponent<RectTransform>().rect.height) >= transform.GetComponent<RectTransform>().rect.height) 
////			{
////				Debug.Log ("I will survive");
////			}
//		}
	}
}