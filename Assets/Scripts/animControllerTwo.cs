using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControllerTwo : MonoBehaviour {

    public Animator anim;
    public AI_Scared aiScared;



	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("q"))
        {
            Debug.Log("Animation played?");
            anim.Play("wallAnimation");
        }
		
	}

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Enemy")// if a gameobject collides with an object called "trigger" it will satisfy conditions of if statement.
        {            
            Debug.Log("You collided with enemy");
            aiScared.ScaredAI();
        }

    }
}
