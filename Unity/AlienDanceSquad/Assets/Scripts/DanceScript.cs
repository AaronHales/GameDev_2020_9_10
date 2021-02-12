using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Game Dev
 * Chapter 4 Activity: Simple Movement and Inputs
 * Aaron Hales
 * 2/12/21
 */

public class DanceScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // handles movement
        transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        // handles rotation
        transform.Rotate(0, 0, Input.GetAxis("Fire1"));

        // handles scaling
        transform.localScale += new Vector3(Input.GetAxis("Fire2"), Input.GetAxis("Fire2"), 0);

    }
}
