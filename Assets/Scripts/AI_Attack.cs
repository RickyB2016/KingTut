using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI_Attack : MonoBehaviour {

	private Sprite[] sprites;
	public AI_Attack ai_attack;
	private float attackTimer;

	void Start()
	{
		int count = 0;
		sprites = new Sprite[7];
		sprites [count++] = Resources.Load("Sprites/heartsprite_0") as Sprite;
		sprites [count++] = Resources.Load("Sprites/heartsprite_1") as Sprite;
		sprites [count++] = Resources.Load("Sprites/heartsprite_2") as Sprite;
		sprites [count++] = Resources.Load("Sprites/heartsprite_3") as Sprite;
		sprites [count++] = Resources.Load("Sprites/heartsprite_4") as Sprite;
		sprites [count++] = Resources.Load("Sprites/heartsprite_5") as Sprite;
		sprites [count++] = Resources.Load("Sprites/heartsprite_6") as Sprite;
	}


	private void OnTriggerStay(Collider col)
	{
		if (attackTimer <= 0){
			
			if (col.tag == "Player") {
				GameObject.FindObjectOfType<Player> ().curHealth -= 1;
				if (GameObject.FindObjectOfType<Player> ().curHealth <= 0) {
					SceneManager.LoadScene ("Main Menu");
				}
				attackTimer = 1;
			}

			GameObject.FindObjectOfType<HealthSystem> ().HeartUI.sprite = sprites [(int)GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().curHealth];
		}
	}

	void Update()
	{
		if (attackTimer > 0)
			attackTimer -= Time.deltaTime;
	}

}
