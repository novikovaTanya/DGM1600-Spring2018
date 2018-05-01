using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed;
	private Transform target;

	void Start() {
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
	}

	void Update() {
		if(Vector2.Distance(transform.position, target.position) > 1)
			transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
	}


	void OnCollisionEnter(Collision collision) {
		//		if (collision.collider.tag == "enemy") {
		Debug.Log("Enemy met " + collision.collider);
		//			FindObjectOfType <GameManager>().GameOver();
		//		}
	}
}
