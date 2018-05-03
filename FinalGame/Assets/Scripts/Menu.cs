using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Nicknames {SuperHero, SuperEgg, StinkyEgg, Weirdo, Player1};

public class Menu : MonoBehaviour {
	public Nicknames nickname = new Nicknames ();

	void Start () {
//		nickname = 
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
