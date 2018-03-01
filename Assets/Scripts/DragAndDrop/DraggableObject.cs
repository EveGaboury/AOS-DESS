using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	[HideInInspector]
	public Transform parentToReturnTo = null;

	public int objectID;
	public static GameObject itemBeingDragged;

	Vector2 startPosition;
	Transform startParent;

//	Transform target;
//	Camera cam;
//	Vector3 position;
//	RectTransform PositionToBE;

	void Start()
	{
		//cam = GetComponent<Camera> ();

//		for (int i = 0; i < position.Length; i++) 
//		{
//			position[i] = new Vector3(0, i -1.0f, 0);
//		}

//		position = new Vector3 (0,-1,0);
//		PositionToBE =  GetComponent<RectTransform>();

//		GameObject workFlow = this.gameObject.GetComponent<Transform> ().position;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		itemBeingDragged = this.gameObject;

		startPosition = transform.position;
		startParent = transform.parent;

		parentToReturnTo = this.transform.parent;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		itemBeingDragged = null; 

		this.transform.SetParent(parentToReturnTo);

		if (transform.parent == startParent) 
		{
			transform.position = startPosition;

			//GameObject workFlow = this.gameObject.GetComponent<Transform> ().position;
			//Vector3 screenPos = cam.WorldToScreenPoint (target.position);
			//Vector3 newPosition = parentToReturnTo.worldToSc
			//this.transform.parent.position = new Vector2(0,0);

			//transform.position = workFlow;
			//transform.position = position;
			//PositionToBE.anchoredPosition = new Vector2 (0,0);
			//transform.position = itemBeingDragged.worlmd
		}
	}
}