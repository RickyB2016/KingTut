using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour 
{

	public int curHealth;
	public int maxHealth = 6;
	public GameOverScript GameOver; 

	private bool damage = true;

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
			SceneManager.LoadScene ("GameOver");

		}
	}

	void Die()
	{
		GameOver.enabled = true;
	}

	public void Health_Off ()
	{
		damage = false;
	}

	public void Health_On ()
	{
		damage = true;
	}


	public void Health_Decrease ()
	{
		if(damage)
		{
			curHealth -= 1;
		}
	}
}
