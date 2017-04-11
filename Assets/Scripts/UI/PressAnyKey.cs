using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PressAnyKey : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void PressedKey()
    {
        SceneManager.LoadScene("Main Menu");
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.anyKey)
        {
            Debug.Log("You pressed any key");
            PressedKey();
        }
		
	}
}
