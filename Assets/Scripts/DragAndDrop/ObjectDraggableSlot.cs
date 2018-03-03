using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ObjectDraggableSlot : MonoBehaviour, IDropHandler
{
	public string[] newText;
	public int[] checkID;

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
					tri.GetComponent<HighlightableText> ().intialText = newText [i];
				}
			}
		}
	}
}