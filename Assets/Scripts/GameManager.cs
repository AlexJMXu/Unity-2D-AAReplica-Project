using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

	public static GameManager instance;

	public Rotator rotator;
	public Spawner spawner;

	public Animator animator;

	void Awake() {
		instance = this;
	}

	public void EndGame() {
		if (!gameHasEnded) {
			rotator.enabled = false;
			spawner.enabled = false;
			animator.SetTrigger("EndGame");
			gameHasEnded = true;
		}
	}

	public void Restart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
