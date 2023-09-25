using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    // creates a variable for the rotation speed
    private float propRotateSpeed = 2000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates the propeller about the z-axis based on rotation speed variable
        transform.Rotate(Vector3.forward, propRotateSpeed * Time.deltaTime);
    }
}
