using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FadeScene : MonoBehaviour {

	public Texture2D fadeOutTexture;
	public float fadeSpeed = 0.7f;
	private int drawdepth = -1000;
	private float alpha = 1.0f ;
	private int dir = -1;
	void OnGUI()
	{
		alpha += dir * fadeSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawdepth;
		GUI.DrawTexture (new Rect(0,0,Screen.width,Screen.height),fadeOutTexture);

	}
	public float BeginFade(int direction)
	{
		dir = direction;
		return fadeSpeed;
	}
	void OnLevelWasLoaded()
	{   
		BeginFade (-1);
	}
}
