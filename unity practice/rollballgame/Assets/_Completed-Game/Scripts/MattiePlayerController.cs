using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class MattiePlayerController : MonoBehaviour {

	//what do we want? for program to check for input every frame and change player position based on that

	//variable for changing movement speed
	public float speed;

	// variables to display count and win text
	public Text countText;
	public Text winText;

	//what the hell is this is this how u set variables in C# help
	private Rigidbody rb;

	// integer to count points
	private int count;

	// i can only assume that this is like a setup function
	void Start() {
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
	}

	void FixedUpdate() {
		// Input is a class, has many variables to support it
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		//Vector3 variable
		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

		// moving the ball relies on applying force to the ball's rigidbody component
		rb.AddForce(movement * speed);

	}

	//collider stuff
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pick Up")) {
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
	}

	//FUNCTIONS
	//SET TEXT COUNT
	void SetCountText() {
		countText.text = "Count: " + count.ToString();
		if (count >= 12) {
			winText.text = "You Win!";
		}
	}

}

// NOTES & QUESTIONS:
// - whats the difference between update and fixedupdate ?
// - floats are just variables
// - goddamn i need to read up on C# syntax i have no idea what anything is
// - YOOOOOOOO IF YOU MAKE A PUBLIC VARIABLE IT JUST STRAIGHT UP SHOWS UP INT HE UNITY INSPECTOR IM LOSING MY SHIT
