using System; using UnityEngine; using UnityEngine.UI; using System.Collections; using UnityEngine.EventSystems; using System.Collections.Generic;  public class CursorScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler { 	//Public 	public Texture2D curTxt_BlocNotes, curTxt_Button, curTxt_Clicked, curTxt_DataOUT, curTxt_DataIN;  	[HideInInspector] 	public string cur_BlocNotes = "curseur3", cur_Bouton = "cursor8", cur_Clicked = "cursor9", cur_DataOUT = "cursor_7", cur_DataIN = "cursor4";  	//Privée 	Vector2 hotSpot = Vector2.zero;  	CursorMode cursorMode = CursorMode.Auto;  	List<GameObject> target = new List<GameObject>();  	UnityEngine.Object[] allCursorTextures;  	GameObject scriptManager;  	void Start()  	{ 		scriptManager = GameObject.Find ("ScriptManager");  		RetrieveCursorsAndAssignThem ();  	}  	public void OnPointerEnter (PointerEventData eventData) 	{ 		if (gameObject.GetComponent<Animator> () == true && gameObject.GetComponent<DataPrefab> () == true)  		{ 			Cursor.SetCursor (curTxt_DataIN, hotSpot, cursorMode); 		} 		else if (gameObject.GetComponent<Button> ().enabled == true && gameObject.GetComponent<NewData> () == true)  		{ 			Cursor.SetCursor (curTxt_DataOUT, hotSpot, cursorMode); 		} 		else if (GetComponent<Button> () == true &&  GetComponent<Button> ().isActiveAndEnabled == true && GetComponent<Button> ().gameObject.activeInHierarchy == true 			&& (GetComponent<NewData> () == false || GetComponent<DataPrefab> () == false))  		{ 			 			Cursor.SetCursor (curTxt_Button, hotSpot, cursorMode); 		} 	}  	public void OnPointerClick(PointerEventData onPointerClickEventData) 	{ 		if (onPointerClickEventData.pointerPress.gameObject.GetComponent<CursorScript>() == true &&  			(onPointerClickEventData.pointerPress.gameObject.GetComponent<Button>().enabled == true || onPointerClickEventData.pointerPress.gameObject.GetComponent<Toggle>() == true))  		{ 			if (onPointerClickEventData.pointerPress.gameObject.GetComponent<LayoutElement>() == true)  			{ 				return; 			} 			Cursor.SetCursor (curTxt_Clicked, hotSpot, cursorMode); 			scriptManager.GetComponent<MousePosition> ().StartThatCoroutine (); 		} 	}  	public void OnPointerExit(PointerEventData onPointerExitEventData)  	{ 		Cursor.SetCursor (null, hotSpot, cursorMode); 	}  	void RetrieveCursorsAndAssignThem() 	{ 		allCursorTextures = Resources.LoadAll ("", typeof(Texture2D));  		for (int i = 0; i < allCursorTextures.Length; i++)  		{ 			if (allCursorTextures[i].name == cur_BlocNotes)  			{ 				curTxt_BlocNotes = allCursorTextures [i] as Texture2D; 			} 			else if (allCursorTextures[i].name == cur_Bouton) 			{ 				curTxt_Button = allCursorTextures[i] as Texture2D;    			} 			else if (allCursorTextures[i].name == cur_Clicked) 			{ 				curTxt_Clicked = allCursorTextures[i] as Texture2D;  			} 			else if (allCursorTextures[i].name ==  cur_DataOUT)  			{ 				curTxt_DataOUT = allCursorTextures[i] as Texture2D;  			} 			else if (allCursorTextures[i].name ==  cur_DataIN)  			{ 				curTxt_DataIN = allCursorTextures[i] as Texture2D;  			} 		} 	} }