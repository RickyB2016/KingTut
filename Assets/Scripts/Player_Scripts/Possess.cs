﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Possess : MonoBehaviour 
{



	// Use this for initialization
	Renderer rend;
	Movement movement; 
    bool rendToggle = false;
	bool movementToggle = true;
    bool closeTo = false;
    public Animator anim;
   // public Animator testAnim;

    public GameObject Player;
    public GameObject possessableObject;


   
 //   public GameObject myChildObject; 
 
	void Start () 
	{
		rend = GetComponent<Renderer> ();	
		movement = GetComponent<Movement> ();
        anim = GetComponent<Animator>();


                  
	}

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.CompareTag("hiero") || col.gameObject.CompareTag("wall") || col.gameObject.CompareTag("tag"))// if a gameobject collides with an object called "trigger" it will satisfy conditions of if statement.
        {
            closeTo = true;
            print("u entered me");

            if (col.gameObject.CompareTag("hiero"))
            {
                print("this is a hiero");
            }
            if (col.gameObject.CompareTag("wall"))
            {
                print("this is a wall");
            }
            if (col.gameObject.CompareTag("tag"))
            {
                print("this is a sphere");
            }

           
            // Destroy(col.gameObject); // does something! 
           
        }
    }
    void OnTriggerExit(Collider col)
    {
        {
            closeTo = false;
            print("you left me");
        }
    }

	void Update() 
	{
		rend.enabled = !rendToggle;
		movement.enabled = movementToggle;



		if (Input.GetKeyDown ("r")) {

			UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
		
		}
		if (Input.GetKeyDown ("n")) {

			SceneManager.LoadScene("HeirScene");


		}
		if (Input.GetKeyDown ("m")) {

			SceneManager.LoadScene("SarScene");

		}

        if (Input.GetKeyDown ("e") && closeTo) 
		{	
			rendToggle = !rendToggle;
			movementToggle = !movementToggle;

                      
         //  Vector3 wallPosition = new Vector3 (-2.32f, 1.28f, -2.92f);
          //  Player.transform.position = wallPosition;
        //   possessableObject.GetComponent<Scare>().enabled = true;

            print ("You pressed E ");
//			
		}

//		
	}
}
 




