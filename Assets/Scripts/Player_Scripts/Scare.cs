using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scare : MonoBehaviour {

    private Animator myAnimator; 
    public Animator myanimation;

	// Use this for initialization
	void Start () {
      
		
        myAnimator = GetComponent<Animator>();
        myAnimator.enabled = false;
        myanimation = GetComponent<Animator>();
        myanimation.enabled = false;
        Time.timeScale = 0.0f;
	}
	
   
	// Update is called once per frame
	void Update () {
         
        if (Input.GetKeyDown("m"))
        {
            Application.Quit();
        }
        
        if (Input.GetKeyDown ("q")) 
        {   
            myAnimator.enabled = true;
           
            myAnimator.Play("WallScare");
            myanimation.enabled = true;
            myanimation.Play("APPROACH");
          print ("You pressed Q ");
                    
        }
	}
}
