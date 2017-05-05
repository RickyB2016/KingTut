using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}



	void OnTriggerEnter(Collider other) {

		if(other.gameObject.CompareTag("Player"))
		{
			SceneManager.LoadScene("Main Menu");
		}

	}


	// Update is called once per frame
	void Update () {



	}
}