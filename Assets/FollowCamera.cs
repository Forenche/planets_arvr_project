using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
 {
    public Transform xrRigCamera;
    
    // Reference to the XR Rig's camera (usually the main camera of the XR rig)
    public float followDistance = 2.0f;  // Distance the object should maintain from the camera

    void Update()
    {
        if (xrRigCamera == null)
        {
            Debug.LogError("XR Rig Camera is not assigned!");
            return;
        }

        // Set the position of the GameObject to follow the XR camera but at a fixed distance
        Vector3 followPosition = xrRigCamera.position + xrRigCamera.forward * followDistance;
        transform.position = followPosition;

    }
}
