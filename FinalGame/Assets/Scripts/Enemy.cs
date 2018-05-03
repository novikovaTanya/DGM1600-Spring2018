using UnityEngine;

public class Enemy : MonoBehaviour {

	public Config config;
	public Transform target;
	public float speed = 3f;


	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
	}

	void Update() {
		transform.LookAt(target.position);
		transform.Rotate(new Vector3(0, -90, 0), Space.Self);

		if (Vector2.Distance(transform.position, target.position) > 3f)
			transform.Translate(new Vector2(config.speed * Time.deltaTime, 0) );
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Player") {
			Player player = collision.collider.GetComponent <PlayerManager> ().player;
			if(player.isLucky())
				Debug.Log ("Player " + player.playerName + " got lucky. No damage");
			else
				FindObjectOfType <GameManager>().GameOver();
		}
	}
}
