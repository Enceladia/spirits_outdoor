using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationCamera : MonoBehaviour
{

    public Transform playerMarker;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(
            transform.position, new Vector3(playerMarker.position.x, 50.0f, playerMarker.position.z), Time.deltaTime * 100);
    }
}
