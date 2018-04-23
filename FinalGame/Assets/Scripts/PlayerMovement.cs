using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 100f;

	void FixedUpdate () {
		rb.AddForce (forwardForce * Time.deltaTime, 0, 0);

		if (Input.GetButton ("Jump"))
			rb.AddForce (2000 * Time.deltaTime, 0, 0);
	}
}
