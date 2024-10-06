using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public float rotationSpeedX; // Speed for X-axis
    public float rotationSpeedY; // Speed for Y-axis
    public float rotationSpeedZ; // Speed for Z-axis

    private void Update() 
    {   
        // Definition of each axis rotation speed
        float rotationX = rotationSpeedX * Time.deltaTime;
        float rotationY = rotationSpeedY * Time.deltaTime;
        float rotationZ = rotationSpeedZ * Time.deltaTime;

        // Rotate on each axis
        transform.Rotate(rotationX, rotationY, rotationZ);

        // Determine and log which axis is being modified
        if (rotationSpeedX != 0)
        {
            Debug.Log("Modifying rotation along the X-axis");
        }
        if (rotationSpeedY != 0)
        {
            Debug.Log("Modifying rotation along the Y-axis");
        }
        if (rotationSpeedZ != 0)
        {
            Debug.Log("Modifying rotation along the Z-axis");
        }
    }
}
