using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rage_script : MonoBehaviour {

	public float delay = 2.0f;
	private float next;

	private bool act = false;

	public BoxCollider boxCollider;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {


			if(Input.GetKeyDown("r") && !act)
			{
				next = Time.time + delay;
				act = true;
				BoxCollider boxCollider = (BoxCollider)GetComponent(typeof(BoxCollider));
				boxCollider.size = new Vector3(100f, 100f, 100f);

				Debug.Log("agro");
			}
			if (next < Time.time && act)
			{
				act = false;

			BoxCollider boxCollider = (BoxCollider)GetComponent(typeof(BoxCollider));
			boxCollider.size = new Vector3(1f, 1f, 1f);
				Debug.Log("Calm");
			}
					

			

			
				
		}


	}



