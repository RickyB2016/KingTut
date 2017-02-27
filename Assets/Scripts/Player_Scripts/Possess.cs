﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Possess : MonoBehaviour 
{



	// Use this for initialization
	public Renderer rend;
	public Movement movement; 
	public bool rendToggle = true;
	public bool movementToggle = true;

	void Start () 
	{
		rend = GetComponent<Renderer> ();
		movement = GetComponent<Movement> ();

	}
	
	void Update() 
	{
		rend.enabled = !rendToggle;
		movement.enabled = movementToggle;

		if (Input.GetKeyDown ("e")) 
		{	
			rendToggle = !rendToggle;
			movementToggle = !movementToggle;

			print ("You Pressed E");
			print ("Where'd you go?! :O");		
//			
		}

//		
	}
}
 