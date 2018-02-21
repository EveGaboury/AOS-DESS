<<<<<<< HEAD:Assets/StartPosition.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour {

	//gamobjects commun
	public GameObject switchSessionCanvas;
	public GameObject blocNoteCanvas;
	public GameObject fenetrePoireCanvas;

	//gameobjects Cass
	public GameObject desktopCass;

	// gameobjects Sophie
	public GameObject desktopSophie;
	public GameObject fenetreFolderSophie;


	void Start () 
	{
		switchSessionCanvas.SetActive (false);
		blocNoteCanvas.SetActive (true);
		fenetrePoireCanvas.SetActive (false);

		desktopCass.SetActive (false);

		desktopSophie.SetActive (true);
		fenetreFolderSophie.SetActive (false);
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
>>>>>>> 2229ef017e2eb8c0eb219eeb67726ce10cadebb5:Assets/Scripts/StartPosition.cs
