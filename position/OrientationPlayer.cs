using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationPlayer : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(90, +Input.compass.magneticHeading, 0);
    }
}
