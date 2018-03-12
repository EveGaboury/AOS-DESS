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

	public GameObject test;

	//public GameObject ButtonC1Clone;


	void Start()
	{
		//ButtonC1Clone.transform.SetParent(Transform newParent);

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

//					Debug.Log("Ceci est le texte: " + tri.captionText.text + " .Contenu dans l'objet: " + tri.gameObject.name);

				//	Debug.Log("Ceci est le texte: " + tri.captionText.text + " .Contenu dans l'objet: " + tri.gameObject.name);


//					tri.transform.SetParent(transform);

					if (tri.GetComponent<Image> ()) 
					{
						DraggableObject dataInstanceIMAGE = Instantiate (tri, Vector3.zero, Quaternion.identity);
						dataInstanceIMAGE.GetComponent<Transform> ().SetParent (dataInstanceIMAGE.startParent);
						dataInstanceIMAGE.GetComponent<Transform> ().localPosition = new Vector2 (tri.PosX, tri.PosY);
						dataInstanceIMAGE.GetComponent<Transform> ().localScale = new Vector2(tri.ScaleX, tri.ScaleY);
						dataInstanceIMAGE.tag= "Untagged";

						tri.transform.SetParent(transform);
						tri.captionText.text = tri.newCaption;
						tri.GetComponent<Selectable> ().enabled = false;
						tri.tag = "NotToBeDeleted";


						dataInstanceIMAGE.enabled = false;
						dataInstanceIMAGE.GetComponent<Selectable> ().enabled = false;
						//Debug.Log ("Une image a été ajoutée au bloc notes: " + tri.name);
						TrackAllReplicants();
					} 
					else if(tri.GetComponent<TextMeshProUGUI> ())
					{
						DraggableObject dataInstanceTEXT = Instantiate (tri, Vector3.zero, Quaternion.identity); //Transform.Parent
						dataInstanceTEXT.GetComponent<Transform> ().SetParent (transform/*dataInstanceTEXT.startParent*/);
						dataInstanceTEXT.GetComponent<Transform> ().localPosition = new Vector2 (tri.PosX, tri.PosY);
						dataInstanceTEXT.GetComponent<Transform> ().localScale = new Vector2(tri.ScaleX, tri.ScaleY);
						dataInstanceTEXT.tag= "NotToBeDeleted";
						dataInstanceTEXT.gameObject.GetComponent<HighlightableText> ().intialText = newText [i];
//						tri.GetComponent<HighlightableText> ().intialText = newText [i];
//						tri.tag = "NotToBeDeleted";

						dataInstanceTEXT.enabled = false;
						dataInstanceTEXT.GetComponent<HighlightableText>().highlighted = dataInstanceTEXT.GetComponent<HighlightableText>().startingColor;
						//Debug.Log ("Une image a été ajoutée au bloc notes: " + tri.name);
						 
						//Debug.Log ("il y a plus qu'un type d'objet dans le bloc notes" + dataInstanceTEXT.GetType());
						TrackAllReplicants();
					}
				}
			}
		}

	}

	void TrackAllReplicants()
	{
		Component[] checkForDuplicates;

		checkForDuplicates = GetComponentsInChildren (typeof(DraggableObject));

		for (int i = 0; i < checkForDuplicates.Length; i++) 
		{
			if (checkForDuplicates[i].GetComponent<Transform> ().tag == "Untagged") 
			{
				Destroy (checkForDuplicates[i].gameObject, .000003f);
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