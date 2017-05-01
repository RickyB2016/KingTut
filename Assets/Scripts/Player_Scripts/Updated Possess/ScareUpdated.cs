using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareUpdated : MonoBehaviour {

	public Animation myanimation;

	private bool used = false;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void tomb_scare ()
	{
		if(!used)
		{
			myanimation.Play();
			used = true;
		}
	}

	public void wall_scare ()
	{
		if (!used)
		{		
			myanimation.Play();
			used = true;
		}
	}

	public void hiero_scare ()
	{
		if (!used)
		{
			myanimation.Play();
			used = true;
		}

	}
}
