using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputFieldTest : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public GameObject itemBeingDragged;

	Vector2 startPosition;
	Transform startParent;
    
	public void OnBeginDrag(PointerEventData eventData)
	{
		itemBeingDragged = this.gameObject;

		startPosition = transform.position;
		startParent = transform.parent;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		itemBeingDragged = null; 

		if (transform.parent == startParent) 
		{
			transform.position = startPosition;
		}
	}
} 



//Source pour le pointer dans le UI: https://stackoverflow.com/questions/41391708/how-to-detect-click-touch-events-on-ui-and-gameobjects && https://gamedev.stackexchange.com/questions/108625/how-to-detect-mouse-over-for-ui-image-in-unity-5


/*
 public class InputFieldTest : MonoBehaviour
{
public int HP = 3;
public static InputFieldTest instance = null;


void Awake()
{
    if (instance == null)
    {
        instance = this;
    }
    else if (instance != this)
    {
        Destroy(gameObject);
    }
}
 */

/*
     //void Update()
//{
//    if (Input.GetKeyUp(KeyCode.G))
//    {
//        GameManager.gaugePsycho++;
//        Debug.Log(GameManager.gaugePsycho);
//    }
//}  
 */

/*
     private static InputFieldTest instance;

private InputFieldTest() { }

public int HP;

public static InputFieldTest Instance
{
    get
    {
        if (instance == null)
        {
            instance = new InputFieldTest();
        }
        return instance;
    } 
}
 */
