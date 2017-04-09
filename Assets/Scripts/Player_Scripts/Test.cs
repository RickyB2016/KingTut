using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour { 
	//Scale sizes & speeds
	public int startSize = 1;
	public int minSize = 1;
	public int maxSize = 300;
	public float speed = 4.0f;
	public GameObject Cube;
	//Timer
	public float delay = 10.0f;
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

            BoxCollider boxCollider = (BoxCollider)GetComponent(typeof(BoxCollider));
            boxCollider.size = new Vector3(100f, 100f, 100f);
			
            act = true;
			Debug.Log("agro");
			ChangeSize (true);
		}
		if (next < Time.time && act) {

			act = false;
			ChangeSize (false);
			movementToggle = !movementToggle;
          
            BoxCollider boxCollider = (BoxCollider)GetComponent(typeof(BoxCollider));
            boxCollider.size = new Vector3(1f, 1f, 1f);
			
            Debug.Log("Calm");
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