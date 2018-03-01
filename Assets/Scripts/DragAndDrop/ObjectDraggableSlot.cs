using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
					tri.GetComponent<HighlightableText> ().intialText = newText [i];
					tri.transform.SetParent(transform);
				}
			}
		}

//		if (tri != null)
//		{
//			tri.parentToReturnTo = this.transform;
//
//			if (tri.objectID == checkID[0]) 
//			{
//				tri.GetComponent<HighlightableText> ().intialText = newText[0];
//			}
//			else if (tri.objectID == 2) //'Rince and repeat'
//			{
//				//Fait de quoi
//			}
		}
	}


   // public GameObject item
   // {
   //     get
   //     {
   //         if (transform.childCount > 0)
   //         {
   //             return transform.GetChild(0).gameObject;
   //         }
   //         return null;
   //     }
   // }

   // public void OnDrop(PointerEventData eventData)
   // {
   //     if (!item)
   //     {
   //         HighlightableText.itemBeingDragged.transform.SetParent(transform);
			////ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, null, (x, y) => x.());
   //     }
   // }