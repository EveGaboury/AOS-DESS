using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ErroneousSearchesDirector : MonoBehaviour 
{
	char[] verification = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
						   'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

	public void Hello_World (string userSearch) 
	{
//		userSearch.Contains (verification);

		for (int i = 0; i < verification.Length; i++) 
		{
			if (userSearch[0] == verification[i]) 
			{
				Debug.Log ("The greatest success of: " + verification[i]);
			}
		}
	}
}
