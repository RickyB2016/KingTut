using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareUpdated : MonoBehaviour {

    private Animator myanimation;

	// Use this for initialization
	void Start ()
    {
        myanimation = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Sphere_Scare ()
    {
        myanimation.Play("Test", -1);
        Debug.Log("You scared!!!!!!!!");
    }

    public void wall_scare ()
    {
        myanimation.Play("Wall", -1);
    }

    public void hiero_scare ()
    {
        //myanimation.Play("", );
    }
}
