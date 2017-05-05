using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControllerTwo : MonoBehaviour {

    public Animator anim;
    public AI_Scared aiScared;
    private bool deathToggle = false; 



	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("q"))
        {
            deathToggle = true; 
            Debug.Log("Animation played?");
            anim.Play("wallAnimation");
        }
		
	}

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Cube" && deathToggle)// if a gameobject collides with an object called "trigger" it will satisfy conditions of if statement.
        {      
            aiScared = col.gameObject.GetComponent<AI_Scared>();
            Debug.Log("You collided with enemy");
            aiScared.ScaredAI();
        }

    }
}
