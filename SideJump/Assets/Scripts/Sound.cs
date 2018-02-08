using UnityEngine.Audio;
using UnityEngine;
[System.Serializable]
public class Sound  {

	public string name;
	public AudioClip clip;

	[Range(.1f,3f)]
	public float pitch;

	[Range(0f,1f)]
	public float volume;

	public bool loop;

	[HideInInspector]
	public AudioSource source;
}
