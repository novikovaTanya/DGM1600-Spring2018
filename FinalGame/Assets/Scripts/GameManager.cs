using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public bool isRunning = true;
	public GameObject completeLevelUI;

	public void GameOver() {
		if (isRunning) {
			Debug.Log ("Game over");
			isRunning = false;
			Invoke("Restart", 0.45f);
		}
	}

	void Restart() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void CompleteLevel() {
		Debug.Log ("Complete Level");
		completeLevelUI.SetActive (true);
	}
}

