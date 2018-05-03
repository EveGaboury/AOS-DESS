using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void Hello ()
	{
	StartCoroutine (Load());
	}

//	public IEnumerator coroutine () {
//
//		yield return new WaitForSeconds (2.0f);
//		SceneManager.LoadScene ("Scene_final");
//		}


	public IEnumerator Load ()
	{  
		//yield return new WaitForSeconds (1.2f);
		AsyncOperation async = Application.LoadLevelAsync("Scene_final");
        yield return async;
        Debug.Log("Loading complete");

	}
}
