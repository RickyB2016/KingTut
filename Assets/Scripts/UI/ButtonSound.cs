using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour {

	// public GameObject audio_source_gameobject;

	public AudioClip audio_clip;

	public AudioSource audio_source;

//	void Start ()
//	{
//		audio_source = audio_source_gameobject.GetComponent<AudioSource> ();
//	}

	public void OnClick ()
	{
		audio_source.PlayOneShot (audio_clip, 1);
	}
}
