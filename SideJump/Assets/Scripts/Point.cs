using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="Player")
		{
			Destroy (gameObject);
			FindObjectOfType<AudioManager> ().Play ("GotPoint");
			Score.score++;
		}
	}
}
