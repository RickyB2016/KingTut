using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Script : MonoBehaviour {

    public GameObject Enemy; 

	// Use this for initialization
    void OnTriggerEnter (Collider othe) 
    {
        if (othe.CompareTag("Enemy"))
        {
            Debug.Log("U GOT THE ENEMY");
            

        }
    }

  /*  void OnTriggerExit (Collider other) 
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("BYE");



        }
    }**/
}