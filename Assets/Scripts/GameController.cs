using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Transform[] cubesSpawnPoints;
	public GameObject cube;
	public Text scoreBoard;

	private int score;
	private Timer timer;

	// Use this for initialization
	void Awake () {
		SpawnFirstCubes ();
		scoreBoard.text = "Score: 0";
	}

	void Start() {
		timer = FindObjectOfType<Timer> ();
	}

	void SpawnFirstCubes() {
		for (int i = 0; i < cubesSpawnPoints.Length; i++) {
			cube = Instantiate (cube, cubesSpawnPoints [i].position, cubesSpawnPoints [i].rotation);
		}
	}

	public void AddScore(int newScore) {
		score += newScore+1;
		UpdateScore ();

	}

	void UpdateScore() {
		if (score == 25) {
			timer.StopTimer (true);
		}
		scoreBoard.text = "Score: " + score;
	}
}
