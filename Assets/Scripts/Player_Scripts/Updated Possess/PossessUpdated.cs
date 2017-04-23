using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossessUpdated : MonoBehaviour {

    private bool closeTo = false;
    bool rendToggle = false;
    bool movementToggle = true;
    Renderer rend;
    Movement movement;

    public GameObject currentPossessable;

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

    void LateUpdate ()
    {
        if(closeTo && currentPossessable != null)
        {
            if (currentPossessable.CompareTag("mummy"))
            {
                Debug.Log("this is a mummy");
                currentPossessable.GetComponent<Scare_Two>().hiero_scare();
                //Scare_Two scarer;
                //scarer = col.gameObject.GetComponent<Scare_Two>();
                //scarer.hiero_scare();

            }
            if (currentPossessable.CompareTag("wall"))
            {
                Debug.Log("this is a wall");
                currentPossessable.GetComponent<Scare_Two>().wall_scare();
                //Scare_Two scarer;
                //scarer = col.gameObject.GetComponent<Scare_Two>();
                //scarer.wall_scare();
            }
            if (currentPossessable.CompareTag("tag"))
            {
                Debug.Log("this is a sphere");
                Debug.Log(currentPossessable.name);

                if (Input.GetKeyDown("q") && closeTo)
                {
                    currentPossessable.GetComponent<Scare_Two>().Sphere_Scare();
                    //Debug.Log("You scared!!!!!!!!");
                    //Scare_Two scarer;
                    //scarer = col.gameObject.GetComponent<Scare_Two>();
                    //scarer.Sphere_Scare();
                }
            }
        }
    }

    void OnTriggerStay(Collider col)
    {
		if (col.gameObject.CompareTag("mummy") || col.gameObject.CompareTag("wall") || col.gameObject.CompareTag("tag"))// if a gameobject collides with an object called "trigger" it will satisfy conditions of if statement.
        {
            currentPossessable = col.gameObject;

            closeTo = true;
            Debug.Log("you are in");
            Debug.Log(closeTo);

            /*
            if (currentPossessable.CompareTag("mummy"))
            {
                Debug.Log("this is a mummy");
                currentPossessable.GetComponent<Scare_Two>().hiero_scare();
                //Scare_Two scarer;
                //scarer = col.gameObject.GetComponent<Scare_Two>();
                //scarer.hiero_scare();

            }
            if (currentPossessable.CompareTag("wall"))
            {
                Debug.Log("this is a wall");
                currentPossessable.GetComponent<Scare_Two>().wall_scare();
                //Scare_Two scarer;
                //scarer = col.gameObject.GetComponent<Scare_Two>();
                //scarer.wall_scare();
            }
            if (currentPossessable.CompareTag("tag"))
            {
                Debug.Log("this is a sphere");
                Debug.Log(currentPossessable.name);

                if (Input.GetKeyDown("q") && closeTo )
                {
                    currentPossessable.GetComponent<Scare_Two>().Sphere_Scare();
                    //Debug.Log("You scared!!!!!!!!");
                    //Scare_Two scarer;
                    //scarer = col.gameObject.GetComponent<Scare_Two>();
                    //scarer.Sphere_Scare();
                }
            }//Req
            */

            // Destroy(col.gameObject); // does something! 

        }
    }

    void OnTriggerExit(Collider col)
    {
        if(currentPossessable != null)
        {
            currentPossessable = null;
            closeTo = false;
            Debug.Log("you left me");
        }
    }
}
