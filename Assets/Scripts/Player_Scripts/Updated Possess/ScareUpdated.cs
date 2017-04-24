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

    public void tomb_scare ()
    {
        myanimation.Play("Tomb scare", -1);
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
