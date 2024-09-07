using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour

{
    public GameObject airplane; 
    public Vector3 offset; 

    void Start()
    {
        // Set the offset to the camera's current position relative to the aircraft
        offset = transform.position - airplane.transform.position;
    }

    void LateUpdate()
    {
     // Reposition the camera next to the aircraft with the defined offset
        transform.position = airplane.transform.position + offset;

    // Ensure that the camera is always looking at the aircraft
        transform.LookAt(airplane.transform);
    }
}