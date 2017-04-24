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
				Debug.Log(currentPossessable.name);
				currentPossessable.GetComponent<ScareUpdated>().hiero_scare();

            }
			if (currentPossessable.CompareTag("wall"))
            {
                Debug.Log("this is a wall");
				Debug.Log(currentPossessable.name);
				currentPossessable.GetComponent<ScareUpdated>().wall_scare();

            }
            if (currentPossessable.CompareTag("Tomb"))
            {
                Debug.Log("this is a Tomb");
                Debug.Log(currentPossessable.name);

                if (Input.GetKeyDown("q") && closeTo)
                {
					currentPossessable.GetComponent<ScareUpdated>().tomb_scare();
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
		
		if (col.gameObject.CompareTag("mummy") || col.gameObject.CompareTag("tag")  || col.gameObject.CompareTag("Tomb")|| col.gameObject.CompareTag("wall"))// if a gameobject collides with an object called "trigger" it will satisfy conditions of if statement.
        {
            currentPossessable = col.gameObject;

            closeTo = true;
            Debug.Log("you are in");
            Debug.Log(closeTo);

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
