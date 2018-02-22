using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectSlot : MonoBehaviour, IDropHandler/*, IPointerEnterHandler, IPointerExitHandler*/
{
	//HighlightableText obj;

	public GameObject item 
	{
		get{
			if (transform.childCount>0) 
			{
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	public void OnDrop(PointerEventData eventData)
	{
		if (!item) 
		{
			HighlightableText.itemBeingDragged.transform.SetParent (transform);
		}
//		ExecuteEvents.ExecuteHierarchy<IHasChanged> (gameObject, null, (x, y) => x.HasCHanged ());
//		obj.GetComponent<Transform> ().transform.SetParent (transform);
	}

//	public void OnPointerExit(PointerEventData eventData)
//	{
//		if (eventData.pointerDrag == null) 
//		{
//			return;
//		}
//
//		HighlightableText h = eventData.pointerDrag.GetComponent<HighlightableText> ();
//
//		if (h != null && h.transform == this.transform) 
//		{
//			h.transform = h.
//		}
//	}
//
//	public void OnDrop(PointerEventData eventData)
//	{
//		Debug.Log (eventData.pointerDrag.name + " dropped on " + gameObject.name);
//
//		HighlightableText h = eventData.pointerDrag.GetComponent<HighlightableText>();
//
//		if (h != null)
//		{
//			h.transform = this.transform;
//		}
//	}
}
