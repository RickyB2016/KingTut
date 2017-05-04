using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Scared : MonoBehaviour {

    public AudioSource scaredSound;
	public AI_Patrol ai_patrol;
	public GameObject mygameobject;


	private void OnTriggerEnter(Collider col)
	{
		//Debug.Log ("Hello");
		if (col.tag == "Player")
		{
			//ai_patrol.enabled = false;
			//Destroy (mygameobject);
            ScaredAI();
        }
	}

    public void ScaredAI(){
        scaredSound.Play();
        ai_patrol.enabled = false;
        Debug.Log("You killed me :O ");
        Destroy (mygameobject);
    }
}