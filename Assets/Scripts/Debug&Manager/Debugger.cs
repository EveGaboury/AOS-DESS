using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    //regarder qu'est ce que c'est le tag editor only

    void Start ()
    {
        this.gameObject.SetActive(false);

        if (Debug.isDebugBuild)
        {
            this.gameObject.SetActive(true);
        }
	}
}
