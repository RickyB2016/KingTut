using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayTester : MonoBehaviour {

    public float delay = 2.0f;
    private float next;

    private bool act = false;


	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown("r") && !act)
        {
            next = Time.time + delay;
            act = true;
            Debug.Log("agro");
        }

        if (next < Time.time && act)
        {
            act = false;
            Debug.Log("Calm");
        }
    }
}
