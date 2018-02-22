using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectSlot : MonoBehaviour/*, IDropHandler, IPointerEnterHandler, IPointerExitHandler*/
{
	HighlightableText obj;

	public void OnDrop(PointerEventData eventData)
	{
//		ExecuteEvents.ExecuteHierarchy<IHasChanged> (gameObject, null, (x, y) => x.HasCHanged ());
//		obj.GetComponent<Transform> ().transform.SetParent (transform);
	}
}
