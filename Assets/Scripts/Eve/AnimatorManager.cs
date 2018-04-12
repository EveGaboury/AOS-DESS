using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {

	public Animator animatorPopUp;

	// Use this for initialization
	void Start () {
		
	}
	
	public void popUpAnim () {

		animatorPopUp.SetBool ("allo", false); 
	}
}
