using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	public Color DefaultColor;
	public Color SecondaryColor;

	private int WhichColor = 0;
	SpriteRenderer spriterenderer;

	public float MoveSpeed = 1;

	GameController gamecontroller;
	// Use this for initialization
	void Start () {
		//So on the intial creation of the obstacle it should be given a random color
		spriterenderer = GetComponent<SpriteRenderer>();
		RandomColor();
	

		GameObject GameEmpty = GameObject.Find ("GameController");
		gamecontroller = GameEmpty.GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Checks to see whether game is running
		if (gamecontroller.GameRunning == true) {
			transform.Translate (-Vector2.up * MoveSpeed * Time.deltaTime);
		}
	}

	void RandomColor () {
		WhichColor = Random.Range(0, 2);
	

		if (WhichColor == 1) {
			spriterenderer.color = DefaultColor;
		} else if (WhichColor == 0) {
			spriterenderer.color = SecondaryColor;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			print("Collided with Player");
			//Stops obstacles moving. This should stop all gameplay
			gamecontroller.EndGame();
		}
	}
		
		
}
