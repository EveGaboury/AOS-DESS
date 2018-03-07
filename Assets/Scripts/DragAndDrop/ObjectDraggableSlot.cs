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
	public string[] imageCaption;
	public int[] checkID;

	void Start()
	{
		//Ceci est là uniquement pour avoir la petite check mark dans l'inspecteur qui permet de désactiver le script

	}

	public void OnDrop (PointerEventData eventData)
	{
		DraggableObject tri = eventData.pointerDrag.GetComponent<DraggableObject> ();

		for (int i = 0; i < checkID.Length; i++) 
		{
			if (tri != null) 
			{
				if (tri.objectID == checkID [i]) 
				{	
				//	Debug.Log("Ceci est le texte: " + tri.captionText.text + " .Contenu dans l'objet: " + tri.gameObject.name);

					tri.transform.SetParent(transform);

					if (tri.GetComponent<Image> ()) 
					{
						DraggableObject dataInstance = Instantiate (tri, Vector3.zero, Quaternion.identity);
						dataInstance.GetComponent<Transform> ().SetParent (dataInstance.startParent);
						dataInstance.GetComponent<Transform> ().localPosition = new Vector2 (tri.PosX, tri.PosY);
						dataInstance.GetComponent<Transform> ().localScale = new Vector2(tri.ScaleX, tri.ScaleY);

						tri.captionText.text = tri.newCaption;


						dataInstance.enabled = false;
						Debug.Log ("Une image a été ajoutée au bloc notes: " + tri.name);
					} 
					else if(tri.GetComponent<TextMeshProUGUI> ())
					{
						DraggableObject dataInstance = Instantiate (tri, Vector3.zero, Quaternion.identity);
						dataInstance.GetComponent<Transform> ().SetParent (dataInstance.startParent);
						dataInstance.GetComponent<Transform> ().localPosition = new Vector2 (tri.PosX, tri.PosY);
						dataInstance.GetComponent<Transform> ().localScale = new Vector2(tri.ScaleX, tri.ScaleY);
						dataInstance.enabled = false;
						dataInstance.GetComponent<HighlightableText>().highlighted = dataInstance.GetComponent<HighlightableText>().startingColor;
						tri.GetComponent<HighlightableText> ().intialText = newText [i];
						Debug.Log ("Une image a été ajoutée au bloc notes: " + tri.name);
					}
//					else 
//					{
//						tri.GetComponent<HighlightableText> ().intialText = newText [i];
//					}
				}
			}
		}
	}

//	void OnTransformChildrenChanged()
//	{
//		Debug.Log(transform.childCount);

//		foreach(RectTransform child in transform)
//		{
			//Debug.Log(child.GetComponent<RectTransform> ().rect.height);
			//list.Add (child);

//			Debug.Log (child.rect.height /*list.Distinct ()*/);
//		}

//		foreach (Transform t in transform) 
//		{
//			list.Add (t);
//			//GameObject[] arr = list.ToArray ();
//			Debug.Log (list.Count /*list.ToArray ()*/ /*(list.Count)*/);
//		}


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
//	}
}