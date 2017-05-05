using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Marks2 : MonoBehaviour {

	public GameObject mark;
	public GameObject mark2;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			mark.gameObject.SetActive (false);
			mark2.gameObject.SetActive (true);
		} 

	}
}
