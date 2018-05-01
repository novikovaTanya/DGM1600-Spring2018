using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerMovement : ScriptableObject {

//	public Rigidbody rb;
	public float speed = 1f;
	public Vector3 direction = Vector3.zero;

	void FixedUpdate () {
//		rb.AddForce (10 * Time.deltaTime, 0, 0);

//		if (Input.GetButton ("Jump"))
//			rb.AddForce (2000 * Time.deltaTime, -1000 * Time.deltaTime, 0);



	}

	public void Move(CharacterController controller, Transform transform) {
//		if (controller.isGrounded) {
//			direction.x = inputX.SetInput() * config.speed;
//			direction.z = inputY.SetInput() * config.speed;
//			direction.y = (Input.GetButton("Jump")) ? config.jumpSpeed : 0;
//
//			direction = transform.TransformDirection(direction);
//		}
		direction.x = 1 * speed;
		direction.y -= 0.1f * Time.deltaTime;
		controller.Move(direction * Time.deltaTime);
	}
}
