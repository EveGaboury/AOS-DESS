using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
//	[HideInInspector]
//	public string naming;

	[TextArea(3,10)]
	public string[] sentences;
}
