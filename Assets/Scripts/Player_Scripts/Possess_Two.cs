using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Possess_Two : MonoBehaviour {

    private bool closeTo = false;
    bool rendToggle = false;
    bool movementToggle = true;
    Renderer rend;
    Movement movement; 

	// Use this for initialization
	void Start ()
    {
        rend = GetComponent<Renderer> (); 
        movement = GetComponent<Movement> ();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rend.enabled = !rendToggle;
        movement.enabled = movementToggle;

        if (Input.GetKeyDown ("e") && closeTo) 
        {   
            rendToggle = !rendToggle;
            movementToggle = !movementToggle;


            //  Vector3 wallPosition = new Vector3 (-2.32f, 1.28f, -2.92f);
            //  Player.transform.position = wallPosition;
            //   possessableObject.GetComponent<Scare>().enabled = true;

            print ("You pressed E ");
                  
        }
	}

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("hiero") || col.gameObject.CompareTag("wall") || col.gameObject.CompareTag("tag"))// if a gameobject collides with an object called "trigger" it will satisfy conditions of if statement.
        {
            closeTo = true;
            print("you are in");

            if (col.gameObject.CompareTag("hiero"))
            {
                print("this is a hiero");
                Scare_Two scarer;
                scarer = col.gameObject.GetComponent<Scare_Two>();
                scarer.hiero_scare();

            }
            if (col.gameObject.CompareTag("wall"))
            {
                print("this is a wall");
                Scare_Two scarer;
                scarer = col.gameObject.GetComponent<Scare_Two>();
                scarer.wall_scare();
            }
            if (col.gameObject.CompareTag("tag"))
            {
                print("this is a sphere");

                if (Input.GetKeyDown("q") && closeTo )
                {
                    Scare_Two scarer;
                    scarer = col.gameObject.GetComponent<Scare_Two>();
                    scarer.Sphere_Scare();
                }
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
}
