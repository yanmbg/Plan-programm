using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    private float propRotationSpeed = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // I made the propeller to spin
        transform.Rotate(Vector3.forward, propRotationSpeed * Time.deltaTime);
    }
}
