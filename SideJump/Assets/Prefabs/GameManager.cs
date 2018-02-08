using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	public float slow = 10f;
	public void EndGame () {
		
		StartCoroutine (RestartLevel());
	}

	IEnumerator RestartLevel() {
		Time.timeScale = 1f / slow;
		Time.fixedDeltaTime /= slow;
		yield return new WaitForSeconds (2f / slow);
		Time.timeScale =1f;
		Time.fixedDeltaTime *= slow;
		SceneManager.LoadScene ("Pause");
	}
}
