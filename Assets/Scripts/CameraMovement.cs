using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // What the camera follows
    public Transform target;

    // Factor at which camera movement is smoothed
    public float smoothing;
    
    void Start()
    {
        
    }
    
    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        if (transform.position != targetPosition)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
