using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour {

	public Text text;
	private int s;
	private int d;
	public int highscore;
	void Start () {
		s = Score.score;
		d = Distance.distance;
		highscore = s * 3 + d;
		text.text = highscore.ToString ();
	}

}
