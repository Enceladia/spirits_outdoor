using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationPlayer : MonoBehaviour
{
    
    void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;
    }
    
    void Update()
    {
        transform.rotation = Quaternion.Euler(90, +Input.compass.magneticHeading, 0);
    }
}
