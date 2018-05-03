using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Menu : MonoBehaviour {
	public enum Nicknames {SuperHero, SuperEgg, StinkyEgg, Weirdo, Player1};
	public Nicknames nickname = new Nicknames ();

	void Start () {
		switch ((int)nickname) {
		case 0:
			Debug.Log ("");
			break;
		default:
			Debug.Log ("ENUM DEFAULT");
			break;
		}
	}
	
	void Update () {
		
	}
}
