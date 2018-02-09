using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColourChange : MonoBehaviour {

	public Color DefaultColor;
	public Color SecondaryColor;

	//Which color is the int which signifies which color is currently displayed
	private int WhichColor = 0;
	SpriteRenderer spriterenderer;
	 
	// Use this for initialization
	void Start () {
		spriterenderer = GetComponent<SpriteRenderer>();
		//Set the GameObject's Color quickly to a set Color (blue)
		spriterenderer.color = DefaultColor;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			if (WhichColor == 1) {
				spriterenderer.color = DefaultColor;
				WhichColor = 0;
			} 

			else if (WhichColor == 0) {
				spriterenderer.color = SecondaryColor;
				WhichColor = 1;
			} else {
				print ("Invalid Color");
			}
				
				

		}
	}
}
