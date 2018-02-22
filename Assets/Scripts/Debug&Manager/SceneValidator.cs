using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;



public class SceneValidator : MonoBehaviour
{
	void Start ()
    {
        this.checkValidGameManager();
	}

    public void checkValidGameManager()
    {
        GameObject[] obs = GameObject.FindGameObjectsWithTag("GameManager");
        // Check size is == 1
        Assert.IsTrue(obs.Length == 1, "You have more than one GameManager in the scene");
    }
}
