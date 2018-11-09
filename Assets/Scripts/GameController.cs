using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Transform[] cubesSpawnPoints;
	public Transform[] nextStageSpawnPoints;
	public GameObject cube;
	public Text scoreBoard;

	private int score;

	// Use this for initialization
	void Awake () {
		SpawnFirstCubes ();
		scoreBoard.text = "Score: 0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnFirstCubes() {
		for (int i = 0; i < cubesSpawnPoints.Length; i++) {
			cube = Instantiate (cube, cubesSpawnPoints [i].position, cubesSpawnPoints [i].rotation);
		}
		for (int i = 0; i < nextStageSpawnPoints.Length; i++) {
			cube = Instantiate (cube, nextStageSpawnPoints [i].position, nextStageSpawnPoints [i].rotation);
		}
	}

	/*public void StartNextStage() {

	}*/

	public void AddScore(int newScore) {
		score += newScore+1;
		UpdateScore ();

	}

	void UpdateScore() {
		scoreBoard.text = "Score: " + score;
	}
}
