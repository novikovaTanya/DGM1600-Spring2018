using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform player;
	public Vector3 offset;



	void LateUpdate () {
		transform.position = player.position + offset;
	}

	public void Start() {
		GameObject[] objects = (GameObject[]) Object.FindObjectsOfType(typeof(GameObject));

		for (int i = 0; i < objects.Length; i++)
			Debug.Log (objects[i]);

		foreach (GameObject obj in objects)
		{
			Debug.Log("Name " + obj.name + " , Tag: " + obj.tag);
		}
			
	}
}
