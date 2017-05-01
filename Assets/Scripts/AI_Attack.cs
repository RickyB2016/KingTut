using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI_Attack : MonoBehaviour {

	private Sprite[] sprites;
	private float attackTimer;

	private GameObject player_gameobject;
	private	Player player_script;

	void Start()
	{
		player_gameobject = GameObject.Find ("CharacterHolder");
		player_script = player_gameobject.gameObject.GetComponent<Player> ();

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
		if (attackTimer <= 0)
		{			
			if (col.tag == "Player") 
			{
				player_script.Health_Decrease ();

				attackTimer = 1;
			}

			//GameObject.FindObjectOfType<HealthSystem> ().HeartUI.sprite = sprites [(int)GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().curHealth];
		}
	}

	void Update()
	{
		if (attackTimer > 0)
			attackTimer -= Time.deltaTime;
	}

}
