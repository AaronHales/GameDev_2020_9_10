using UnityEngine;
using System.Collections;

public class SharkScript : MonoBehaviour {

	// declare the score variable and set to 0
	int score = 0;

	// Use this for initialization
	void Start () 
	{
		Debug.Log("Score = " + score);
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move the shark according to the inputs
		transform.Translate (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
	}

	void OnCollisionEnter2D (Collision2D otherObject) 
	{
		score++;
		Debug.Log("Score = " + score);
	}
}
