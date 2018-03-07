using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	[HideInInspector]
	public Transform parentToReturnTo = null, startParent;

	public float PosX, PosY, ScaleX, ScaleY;

	public int objectID;

	public static GameObject itemBeingDragged;

	Vector2 startPosition;


	void Start()
	{

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

		//this.transform.SetParent(parentToReturnTo);

		if (transform.parent == startParent) 
		{
			transform.position = startPosition;
		}
	}
}