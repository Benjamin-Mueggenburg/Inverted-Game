using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	//Public variable controlling the speed at which the player moves side to side
	public float speed;

	//Colors that the player will switch between
	public Color DefaultColor;
	public Color SecondaryColor;

	//Which color is the int which signifies which color is currently displayed
	private int WhichColor = 0;
	SpriteRenderer spriterenderer;

	//Rigidbody Setup
	private Rigidbody2D rb2d;

	// Gets the gamecontroller object variables setup
	GameController gamecontroller;

	// Use this for initialization
	void Start ()
	{
		spriterenderer = GetComponent<SpriteRenderer>();
		//Set the GameObject's Color quickly to a set Color (blue)
		spriterenderer.color = DefaultColor;

		GameObject GameEmpty = GameObject.Find ("GameController");
		gamecontroller = GameEmpty.GetComponent<GameController> ();

		//Get rigid body component of player. Will be used to move the player
		rb2d = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update ()
	{

		if (gamecontroller.GameRunning == true) {

			if (Input.GetKeyDown (KeyCode.C)) {
				if (WhichColor == 1) {
					spriterenderer.color = DefaultColor;
					WhichColor = 0;
				} else if (WhichColor == 0) {
					spriterenderer.color = SecondaryColor;
					WhichColor = 1;
				} else {
					print ("Invalid Color");
				}
				


			}
		}
	}

	void FixedUpdate() 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorizontal, 0.0f);
		rb2d.AddForce (movement * speed);
	}




}

