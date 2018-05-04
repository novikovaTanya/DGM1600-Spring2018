using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {

	public float count = 0f;
	public Text countText;

	void Update () {
		count += Time.deltaTime * 10;
		countText.text = count.ToString("000");

		if (count / 10000 > 1)
			Debug.Log ("Reached max time");
	}
}
