using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {

	public void ChangeToScene(string scene) 
	{
		StartCoroutine (Restart(scene));
	}

	IEnumerator Restart(string scene) {
		float fadeTime = GameObject.Find ("Fade").GetComponent<FadeScene> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene (scene);	
	}
	public void Exit()
	{
		Application.Quit ();
	}

}
