using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scare : MonoBehaviour {

    private Animator myAnimator; 
    public Animator myanimation;
	public bool animatorToggle = false;
	public bool animationToggle = false;

	// Use this for initialization
	void Start () {
      
        myAnimator = GetComponent<Animator>();
        myAnimator.enabled = false;
        myanimation = GetComponent<Animator>();
        myanimation.enabled = false;
        
	}
	
   
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown("p"))
        {
            Application.Quit();
        }
        
        if (Input.GetKeyDown ("q")) 
        {   
          //myAnimator.enabled = true;
			myAnimator.enabled = !animatorToggle;
			myanimation.enabled = !animationToggle;
         // myanimation.enabled = true;

           
          print ("You pressed Q ");
                    
        }
	}
}
