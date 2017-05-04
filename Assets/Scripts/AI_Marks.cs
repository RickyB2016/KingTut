using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Marks : MonoBehaviour {


	public GameObject mark;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			mark.gameObject.SetActive (true);
		} 

	}

}

