using UnityEngine;
using System.Collections;


public class Test : MonoBehaviour { 

	public AudioSource enraged;
	public AudioSource rageLost;
	//Scale sizes & speeds
	public int startSize = 1;
	public int minSize = 1;
	public int maxSize = 300;
	public float speed = 1.0f;
	public GameObject Cube;
	//Timer
	public float delay = 3.0f;
	//TOggle
	public bool movementToggle = true;

	//Script components
	public Movement movement;


	private float next;
	private bool act = false;

	private Vector3 targetScale;
	private Vector3 baseScale;
	private int currScale;
	private Vector3 moveDirection = Vector3.zero;



	// Rage Enemy Disable
	public Player player_script;

	// Rage Particle Effect
	public GameObject particle;

	void Start() {
		baseScale = transform.localScale;
		transform.localScale = baseScale * startSize;
		currScale = startSize;
		targetScale = baseScale * startSize;
		movement = GetComponent<Movement> ();
	}

	void Update() {
		movement.enabled = movementToggle;
		transform.localScale = Vector3.Lerp (transform.localScale, targetScale, speed * Time.deltaTime);


		// If you don't want an eased scaling, replace the above line with the following line
		//   and change speed to suit:
		// transform.localScale = Vector3.MoveTowards (transform.localScale, targetScale, speed * Time.deltaTime);

		if (Input.GetKeyDown ("f") && !act) {
			//Cube.GetComponent<Movement> ().LaunchRage ();
			//movementToggle = !movementToggle;
			//Cube.GetComponent<Movement> ().LaunchRage ();
			next = Time.time + delay;
			movementToggle = !movementToggle;
			enraged.Play();

			particle.gameObject.SetActive (true);

			CapsuleCollider capsule_collider = (CapsuleCollider)GetComponent(typeof(CapsuleCollider));
			capsule_collider.radius = 2.0f;
			capsule_collider.height = 3.0f;			
			act = true;
			Debug.Log("agro");
			ChangeSize (true);

			player_script.Health_Off ();
		}
		if (next < Time.time && act) {

			act = false;
			ChangeSize (false);
			movementToggle = !movementToggle;
			rageLost.Play();

			particle.gameObject.SetActive (false);

			CapsuleCollider capsule_collider_two = (CapsuleCollider)GetComponent(typeof(CapsuleCollider));
			capsule_collider_two.radius = 0.5f;
			capsule_collider_two.height = 1.0f;			
			Debug.Log("Calm");
			player_script.Health_On ();




		}
	}


	public void ChangeSize(bool bigger) {

		if (bigger)
			currScale++;
		else
			currScale--;

		currScale = Mathf.Clamp (currScale, minSize, maxSize+1);

		targetScale = baseScale * currScale;
	}    
}