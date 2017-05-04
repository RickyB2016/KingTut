using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossessUpdated : MonoBehaviour {
    public AudioSource possessed;
    private bool closeTo = false;
    bool rendToggle = false;
    bool movementToggle = true;
    bool possessToggle = false; 
    Renderer rend;
    Movement movement;


    public GameObject bobbing;
    public bool bobbing_active = true;

    private GameObject currentPossessable;

    // Use this for initialization
    void Start ()
    {
        rend = GetComponent<Renderer> (); 
        movement = GetComponent<Movement> ();
    }

    // Update is called once per frame
    void Update ()
    {
        if(bobbing_active)
        {
            bobbing.SetActive(true);
        }
        else
        {
            bobbing.SetActive(false);
        }

        rend.enabled = !rendToggle;
        movement.enabled = movementToggle;

        /*if (Input.GetKeyDown ("e") && closeTo) 
        {   
            rendToggle = !rendToggle;
            movementToggle = !movementToggle;
            bobbing_active = !bobbing_active;


            //  Vector3 wallPosition = new Vector3 (-2.32f, 1.28f, -2.92f);
            //  Player.transform.position = wallPosition;
            //   possessableObject.GetComponent<Scare>().enabled = true;

            print ("You pressed E ");

        }**/
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
                if (Input.GetKeyDown ("e") && closeTo) 
                {   
                    possessed.Play();
                    rendToggle = !rendToggle;
                    movementToggle = !movementToggle;
                    bobbing_active = !bobbing_active;
                    Debug.Log("You pressed E inside me");
                    currentPossessable.GetComponent<animControllerTwo>().enabled =!currentPossessable.GetComponent<animControllerTwo>().enabled;
                    print ("You pressed E ");
                }
            }
            if (currentPossessable.CompareTag("Tomb"))
            {

                if (Input.GetKeyDown ("e") && closeTo) 
                {   
                    possessed.Play();
                    rendToggle = !rendToggle;
                    movementToggle = !movementToggle;
                    bobbing_active = !bobbing_active;
                    Debug.Log("You pressed E inside me");
                    currentPossessable.GetComponent<animController>().enabled =!currentPossessable.GetComponent<animController>().enabled;
                    print ("You pressed E ");
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
