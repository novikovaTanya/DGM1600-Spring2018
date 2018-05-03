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

	private void GameOver() {
		FindObjectOfType <GameManager>().GameOver();
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "enemy" && player.isWeak())
			GameOver();
	}

	public void Update() {
		if (player.health < 0) {
			GameOver ();
			player.health = 100;
		}
		else if (player.health > 100)
			player.health = 100;
		
		movement.Move(controller, transform);
	}
}
