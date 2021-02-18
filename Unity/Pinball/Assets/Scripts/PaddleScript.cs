using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Game Development
 * Chapter 5 Activity: Simple Pinball
 * Aaron Hales
 * 2/18/21
 */

public class PaddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
    }
}
