using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Nicknames {SuperHero, SuperEgg, StinkyEgg, Weirdo, Player1};

public class PlayerManager : MonoBehaviour {

	public Player player;
	public PlayerMovement movement;
	private CharacterController controller;

	private void Start() {
		controller = GetComponent<CharacterController>();
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "enemy" && player.isWeak()) {
			FindObjectOfType <GameManager>().GameOver();
		}
	}

	void Update() {
		movement.Move(controller, transform);
	}
}
