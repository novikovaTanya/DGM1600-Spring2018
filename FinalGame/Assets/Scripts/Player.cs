using UnityEngine;

[CreateAssetMenu]
public class Player : ScriptableObject
{
	public int health;
	public int score;
	public string playerName;
	private bool nameChosen = false;

	private void OnEnable() {
		int size = Nicknames.GetValues (typeof(Nicknames)).Length;
		Nicknames nickname = new Nicknames ();

		while (!nameChosen) {
			nickname = PickName (size);
			if (nickname != Nicknames.Player1)
				nameChosen = true;
		}

		playerName = nickname.ToString();
		Debug.Log ("Hello, " + playerName);
	}

	private Nicknames PickName(int size) {
		return (Nicknames)Random.Range (0, size - 1);
	}

	public bool isLucky() {
		return (bool)(Random.value > 0.5f);
	}

	public bool isWeak() {
		return health < 20;
	}
}