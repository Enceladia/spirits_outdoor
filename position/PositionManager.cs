﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionManager : MonoBehaviour {

    public float playerPosX = 0.0f;
    public float playerPosZ = 0.0f;

    private float startLat = 0;
    private float startLng = 0;

    IEnumerator StartGPSservice()
    {
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield break;

        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            print("Timed out");
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            print("Unable to determine device location");
            yield break;
        }
        else
        {
            // Access granted and location value could be retrieved
            print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);

            startLat = Input.location.lastData.latitude;
            startLng = Input.location.lastData.longitude;
        }

        // Stop service if there is no need to query location updates continuously
        //Input.location.Stop();
    }

    void Start()
    {
        StartCoroutine(StartGPSservice());

        //Positioniere Overworld Objekte
    }

    void Update()
    {
        playerPosX = getWorldPosToUnityPos(Input.location.lastData.latitude);
        playerPosZ = getWorldPosToUnityPos(Input.location.lastData.longitude);
    }

    private float getWorldPosToUnityPos(float pos)
    {
        return (startLat - pos) * 10000.0f;
    }


}