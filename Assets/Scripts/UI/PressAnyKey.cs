using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PressAnyKey : MonoBehaviour {

	public AudioSource audio_source;
	public AudioClip audio_clip; 
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
			audio_source.PlayOneShot (audio_clip, 1);
            Debug.Log("You pressed any key");
            PressedKey();

        }
		
	}
}
