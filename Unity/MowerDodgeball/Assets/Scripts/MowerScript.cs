/* Unity Game Programming
 * Mower Dodgeball Project
 * Aaron Hales
 * 3/11/21
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MowerScript : MonoBehaviour 
{
	// declare variables to track and display 
	// the number of hits this mower has taken
	public Text scoreText;
	private int myHits;

	// Use this for initialization
	void Start () 
	{
		// initialize score variables
		myHits = 0;
		scoreText.text = "Score: " + myHits;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// declare variable to hold steering input
		float steering = 0;

		if (tag.Equals("Orange"))
		{
			steering = Input.GetAxis("Horizontal");
		}
		else if (tag.Equals("Blue"))
		{
			steering = Input.GetAxis("Horizontal2");
		}

		// rotate mower left or right based on user input
		// change the * scale factor to adjust sensitivity
		transform.Rotate(0,0,-steering * 10);

		// move the mower ahead at a constant rate
		// change the X value to modify mower speed
		transform.Translate (0.02F,0,0);
	}

	void OnCollisionEnter2D(Collision2D otherObject)
	{
		string otherTag = otherObject.gameObject.tag;
		if (otherTag.Equals("Orange") && (tag.Equals("Blue")))
		{
			myHits++;
			scoreText.text = "Score: " + myHits;
		}

		if (otherTag.Equals("Blue") && (tag.Equals("Orange")))
		{
			myHits++;
			scoreText.text = "Score: " + myHits;
		}

	}
}
