using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePosition : MonoBehaviour 
{
	//Public
	public Sprite curTxt_BlocNotes, curTxt_Button, curTxt_DataOUT, curTxt_DataIN;

	public string cur_BlocNotes, cur_Bouton, cur_DataOUT, cur_DataIN;

	[HideInInspector]
	public Sprite startImage;

	[HideInInspector]
	public Animator m_Animator;

	//Privée
	Vector2 mousePos;

	UnityEngine.Object[] sprites;

	void Start() 
	{
		Cursor.visible = false;
	
		mousePos = new Vector2 ();

		m_Animator = GetComponent<Animator> ();

		RetrieveCursorsAndAssignThem ();

		for (int i = 0; i < sprites.Length; i++) 
		{
			if (sprites[i].name == "DefaultCursor") 
			{
				GetComponent<Image> ().sprite = sprites[i] as Sprite;
			}

		}
	}

	void Update()
	{
		mousePos = Input.mousePosition; 

		transform.position = mousePos;
	}

	void RetrieveCursorsAndAssignThem()
	{
		sprites = Resources.LoadAll ("", typeof(Sprite));

		for (int i = 0; i < sprites.Length; i++) 
		{
			if (sprites[i].name == cur_BlocNotes) 
			{
				curTxt_BlocNotes = sprites [i] as Sprite;
			}
			else if (sprites[i].name == cur_Bouton)
			{
				curTxt_Button = sprites[i] as Sprite;   
			}
			else if (sprites[i].name ==  cur_DataOUT) 
			{
				curTxt_DataOUT = sprites[i] as Sprite; 
			}
			else if (sprites[i].name ==  cur_DataIN) 
			{
				curTxt_DataIN = sprites[i] as Sprite; 
			}
		}
	}
}