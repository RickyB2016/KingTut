﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour 
{

	public int curHealth;
	public int maxHealth = 6;

	private bool damage = true;

	public AudioClip hurtSound;
	public AudioSource audio;

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
			SceneManager.LoadScene ("Main Menu");

		}
	}

	void Die()
	{
		SceneManager.LoadScene ("Main Menu");
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
			audio.PlayOneShot (hurtSound, 0.9f);
		}
	}
}