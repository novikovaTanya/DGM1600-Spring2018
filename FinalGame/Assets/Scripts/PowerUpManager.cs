using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour {

	public PowerUp powerUp;

	public void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Player player = other.GetComponent <PlayerManager> ().player;
			player.ApplyPowerUp (powerUp);
			Debug.Log (player.playerName);
		}
	}
}
