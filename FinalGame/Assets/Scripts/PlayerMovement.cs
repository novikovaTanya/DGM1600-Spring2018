using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerMovement : ScriptableObject {

	public Config config;
	public Vector3 direction = Vector3.zero;

	public void Move(CharacterController controller, Transform transform) {
		if (controller.isGrounded) {
			Debug.Log (Input.GetButton("Jump"));
			direction.x = Input.GetAxis("Horizontal") * config.speed;
			direction.y = (Input.GetButton("Jump")) ? config.jumpSpeed : 0;

			direction = transform.TransformDirection(direction);
		}
		direction.y -= config.gravity * Time.deltaTime;
		controller.Move(direction * Time.deltaTime);
	}
}
