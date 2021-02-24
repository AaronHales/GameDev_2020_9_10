using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Game Development
 * Chapter 5 Activity: Simple Pinball
 * Aaron Hales
 * 2/18/21
 */

public class BallScript : MonoBehaviour
{
  int score = 0;
  public Text scoreText;
  public Text gameOverText;

    void OnTriggerEnter2D(Collider2D otherObject)
    {
      Debug.Log("Game Over!");
      gameOverText.text = "Game Over!";
    }

    void OnCollisionEnter2D(Collision2D otherObject) 
    {
      // print a message showing  physics-based collisions
      Debug.Log("Collision with " + otherObject.gameObject.name);
      score++;
      scoreText.text = "Score: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
      scoreText.text = "Score: " + score;
      gameOverText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
