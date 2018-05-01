using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {


	public void PlayMainScene ()
		{

		coroutine ();

		}


	public IEnumerator coroutine () {

		yield return new WaitForSeconds (2.0f);
		SceneManager.LoadScene ("Scene_final");
		}
}
