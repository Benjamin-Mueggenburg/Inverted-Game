using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public bool GameRunning = true;
	public int GameDifficulty = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EndGame () {
		//Stops all physics (as add force is used for the movement of the player
		Time.timeScale = 0.0f;
		GameRunning = false;
	}
}
