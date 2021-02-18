using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Game Development
 * Chapter 5 Activity: Simple Pinball
 * Aaron Hales
 * 2/18/21
 */

public class BallScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        Debug.Log("Game Over!");
    }

    void OnCollisionEnter2D(Collision2D otherObject) 
    {
      // print a message showing  physics-based collisions
      Debug.Log("Collision with " + otherObject.gameObject.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
