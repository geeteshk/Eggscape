using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // What the camera follows
    public Transform target;

    // Factor at which camera movement is smoothed
    public float smoothing;

    // Camera bounds
    public Vector2 cameraMin;
    public Vector2 cameraMax;
    
    void Start()
    {
        
    }
    
    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        if (transform.position != targetPosition)
        {
            targetPosition.x = Mathf.Clamp(targetPosition.x, cameraMin.x, cameraMax.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, cameraMin.y, cameraMax.y);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
