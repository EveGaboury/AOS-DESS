using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ManageNonInteractableDialogue : MonoBehaviour
{
	[HideInInspector]
	public string[] conversations = new string[] {"conversation1", "conversation2", "conversation3", "conversation4"}, 
	interlocuteurs = new string[] {"Anonyme1", "Anonyme2"};

	private List<GameObject> profileOfMessengerFirends = new List<GameObject>(), conversationBubblesHolders = new List<GameObject>();

	private string currentButton;

	private GameObject prefab;

	void Start () 
	{
		prefab = GameObject.Find ("display");

		RetrieveProfiles ();

//		FindAllGameObjectsWithTags ();
	}

	public void CheckThatName()
	{
		currentButton = EventSystem.current.currentSelectedGameObject.name;

		WhenThisButtonIsClickedMakeItTellItsName ();
	}

	void RetrieveProfiles()
	{
		Transform[] allChildren = GetComponentsInChildren<Transform> (true);

//		Debug.Log ("Transform[] allChildren value is: " + allChildren.Length);

		foreach (Transform child in allChildren) 
		{
			if (child.gameObject.GetComponent<Button> () != null && child.gameObject.tag == "ProfileMessenger") 
			{
				profileOfMessengerFirends.Add (child.gameObject);

				for (int z = 0; z < profileOfMessengerFirends.Count; z++) 
				{
					Transform[] allSons = profileOfMessengerFirends[z].gameObject.GetComponentsInChildren<Transform> (true);

//					Debug.Log (profileOfMessengerFirends[z] + " Transform[] allSons value is: " + allSons.Length);

					foreach (Transform item in allSons) 
					{
						for (int y = 0; y < interlocuteurs.Length; y++) 
						{
							for (int x = 0; x < conversations.Length; x++)
							{
								if ((item.gameObject.tag == interlocuteurs[y]) && (item.gameObject.name == conversations[x])) 
								{
									conversationBubblesHolders.Add (item.gameObject);
								}
							}
						}
					}
				}
			}
		}
	}

	void WhenThisButtonIsClickedMakeItTellItsName()
	{
		if(prefab.GetComponentInChildren<Transform>().childCount == 0)
		{
			for (int i = 0; i < profileOfMessengerFirends.Count; i++) 
			{
				if (profileOfMessengerFirends[i].gameObject.name == currentButton) 
				{
					for (int j = 0; j < profileOfMessengerFirends[i].GetComponentsInChildren<Transform>(true).Length; j++)
					{
						for (int k = 0; k < conversations.Length; k++)
						{
							if (profileOfMessengerFirends [i].GetComponentsInChildren<Transform> (true) [j].name == conversations[k]) 
							{
								for (int l = 0; l < profileOfMessengerFirends [i].GetComponentsInChildren<Transform> (true) [j].GetComponentsInChildren<Image> ().Length; l++)
								{
									Image[] locallyUndefinedArray = profileOfMessengerFirends [i].GetComponentsInChildren<Transform> (true) [j].GetComponentsInChildren<Image>();

									for (int m = 0; m < locallyUndefinedArray.Length; m++)
									{
										locallyUndefinedArray [m].gameObject.GetComponent<Transform> ().transform.SetParent (prefab.transform);
									}
								}
							}
						}
					}
				}
			}
		}
		else if(prefab.gameObject.GetComponentInChildren<Transform>().childCount != null)
		{
			for (int n = 0; n < prefab.GetComponentsInChildren<Transform>().Length; n++) 
			{
				foreach (Transform child in prefab.gameObject.GetComponentsInChildren<Transform>()) 
				{
					for (int s = 0; s < interlocuteurs.Length; s++)
					{
						if (child.gameObject.tag == interlocuteurs[s]) 
						{
							for (int a = 0; a < conversationBubblesHolders.Count; a++) 
							{
								if (conversationBubblesHolders[a].tag == child.gameObject.tag) 
								{
									child.gameObject.transform.SetParent (conversationBubblesHolders[a].transform);
								}
							}
						}
					}
				}
			}
		}
	}

//	void FindAllGameObjectsWithTags()
//	{
//		for (int i = 0; i < UnityEditorInternal.InternalEditorUtility.tags.Length; i++) 
//		{
//			Debug.Log(UnityEditorInternal.InternalEditorUtility.tags[i]);
//		}
//	}
}