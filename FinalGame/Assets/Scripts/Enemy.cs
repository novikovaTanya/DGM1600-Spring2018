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
//	private Transform target;
//
//	void Start() {
//		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
//	}
//
//	void Update() {
////		if(Vector2.Distance(transform.position, target.position) > 3)
////			transform.position = Vector2.MoveTowards(transform.position, target.position, config.speed * Time.deltaTime);
//	}
//
//
//	void FixedUpdate () {
//		transform.LookAt (target.position);
//		transform.Rotate(new Vector3(0,-90,0),Space.Self);
//
//		if(Vector2.Distance(transform.position, target.position) > 3)
//			transform.Translate(new Vector2(3f * Time.deltaTime, 0) );
//		
//		Debug.DrawLine (transform.position, target.position);
////		transform.position -= transform.TransformDirection (Vector2.up) * 0.1f ;
//	}

	void OnCollisionEnter(Collision collision) {
		//		if (collision.collider.tag == "enemy") {
		Debug.Log("Enemy met " + collision.collider);
		//			FindObjectOfType <GameManager>().GameOver();
		//		}
	}
}
