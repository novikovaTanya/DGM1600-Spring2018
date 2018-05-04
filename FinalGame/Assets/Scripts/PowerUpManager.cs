using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour {

	public PowerUp powerUp;
	public Transform effect;

	public void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Player player = other.GetComponent <PlayerManager> ().player;
			player.ApplyPowerUp (powerUp);

			if (powerUp.name == "Damage") {
				Transform e = Instantiate (effect, transform.position, transform.rotation);
				Destroy (e);
			}

			Destroy (gameObject);
		}
	}
}
