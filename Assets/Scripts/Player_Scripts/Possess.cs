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
    public GameObject Player;
    public GameObject possessableObject;
   
 //   public GameObject myChildObject; 
 
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

                      
         //  Vector3 wallPosition = new Vector3 (-2.32f, 1.28f, -2.92f);
          //  Player.transform.position = wallPosition;
           possessableObject.GetComponent<Scare>().enabled = true;

            print ("You pressed E ");
//			
		}

//		
	}
}
 




/* COLLIDE ON ENTER
 * void OnCollisionEnter(Collision col)
 *{
 *  if(col.gameObject.name == "trigger") // if a gameobject collides with an object called "trigger" it will satisfy conditions of if statement.
 * {
 *  Destroy(col.gameObject); // does something! 
 * }
 *}*/