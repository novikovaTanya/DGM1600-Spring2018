﻿using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform player;
	public Vector3 offset;


	void LateUpdate () {
		transform.position = player.position + offset;
	}

	void Update() {
		Debug.Log (player.position);
	}
}
