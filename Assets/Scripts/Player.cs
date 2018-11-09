using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Rigidbody rb;
	public float speed;

	private float moveHorizontal;
	private float moveVertical;
	private Vector3 movement;
	private Controller controller;
	private GameController gameController;
	private int score;

	// Use this for initialization
	void Awake() {
		rb = GetComponent<Rigidbody> ();
		score = 0;
		gameController = FindObjectOfType<GameController> ();
	}

	void Start() {
	}
	
	// Update is called once per frame
	void Update () {
		moveVertical = Input.GetAxis ("Vertical");
		moveHorizontal = Input.GetAxis ("Horizontal");

		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Cube") {
			other.gameObject.SetActive (false);
			gameController.AddScore (score);
		}
		if (other.tag == "Flag") {
			//gameController.StartNextStage ();
			Destroy (other.gameObject);
		}
	}
}
