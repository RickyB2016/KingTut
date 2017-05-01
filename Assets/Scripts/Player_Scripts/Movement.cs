using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 20.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	public GameObject tutAnimation; 


	public void LaunchRage()
	{
		moveDirection.y = jumpSpeed;
		print ("u jumped");
	}
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			//if (Input.GetButton("Jump"))
			//moveDirection.y = jumpSpeed;
			if (Input.GetKeyDown(KeyCode.W))
				tutAnimation.transform.forward = new Vector3(0f, 0f, 1f);
			else if (Input.GetKeyDown(KeyCode.S))
				tutAnimation.transform.forward = new Vector3(0f, 0f, -1f);
			else if (Input.GetKeyDown(KeyCode.D))
				tutAnimation.transform.forward = new Vector3(1f, 0f, 0f);
			else if (Input.GetKeyDown(KeyCode.A))
				tutAnimation.transform.forward = new Vector3(-1f, 0f, 0f);
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

}
