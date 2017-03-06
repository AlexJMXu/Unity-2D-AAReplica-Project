using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	private bool isPinned = false;

	public float speed = 20f;
	public Rigidbody2D rb;

	GameManager gameManager;

	void Start() {
		gameManager = GameManager.instance;
	}

	void Update() {
		if (!isPinned) rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.CompareTag("Rotator")) {
			transform.SetParent(col.transform);
			Score.PinCount++;
			isPinned = true;
		} else if (col.CompareTag("Pin")) {
			gameManager.EndGame();
		}
	}
}
