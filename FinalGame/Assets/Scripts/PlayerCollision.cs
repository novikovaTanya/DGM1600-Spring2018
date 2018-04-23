using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "obstacle")
//			movement.enabled = false;
			Debug.Log("sd");
	}
}
