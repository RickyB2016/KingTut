using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {


	private float timeleft;
	public Movement movementScript;

	// Use this for initialization
	void Start ()
	{
		timeleft = 4;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (timeleft);
		if (timeleft > 0)
			timeleft -= Time.deltaTime;
		movementScript.enabled = false;

		if(timeleft <= 0)
		{
			
			GameOverTimer ();
		}
	}

	public void GameOverTimer()
	{
		print("active");
		SceneManager.LoadScene("Main Menu");
	}
		
}

