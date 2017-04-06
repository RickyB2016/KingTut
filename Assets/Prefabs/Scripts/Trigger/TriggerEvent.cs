using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {
          
    public GameObject Player; 
    public GameObject canvas; 

   
   void OnTriggerEnter (Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("U HAVE PENETRATED MY TRIGGER");
            Player.GetComponent<Possess>().enabled = true;

        }
    }

    void OnTriggerExit (Collider other) 
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("BYE");
            Player.GetComponent<Possess>().enabled = false;
           

        }
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 1.0f;
            //canvas.activeSelf = false;
            canvas.SetActive(false);

        }
    }

}
