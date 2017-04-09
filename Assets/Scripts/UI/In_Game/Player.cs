using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public int curHealth;
	public int maxHealth = 6;

	void Start () 
	{
		curHealth = maxHealth;
	}
	

	void Update () 
	{
		if (curHealth > maxHealth) 
		{
			curHealth = maxHealth;
		}

		if (curHealth <= 0) 
		{
			Die ();
		}
	}

	void Die()
	{
		// Load a Level after you die.
		SceneManager.LoadScene ("firstattempt");
	}
}
