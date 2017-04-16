using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionManager : MonoBehaviour {

    public float playerPosX = 0.0f;
    public float playerPosZ = 0.0f;

    public float startLat = 0;
    public float startLng = 0;

    private bool startPoi = false;

    IEnumerator StartGPSservice()
    {
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield break;

        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes
        int maxWait = 5;
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

            if (!startPoi)
            {

                startLat = Input.location.lastData.latitude;
                startLng = Input.location.lastData.longitude;

                startPOIGeneration();

                startPoi = true;
            }
        }
    }

    void Awake()
    {
        StartCoroutine(StartGPSservice());
    }

    void Update()
    {
        playerPosX = getLatToUnityPos(Input.location.lastData.latitude);
        playerPosZ = getLngToUnityPos(Input.location.lastData.longitude);
    }

    private void LateUpdate()
    {
        StartCoroutine(StartGPSservice());
    }

    public float getLatToUnityPos(float pos)
    {
        return (pos - startLat) * 10000.0f;
    }

    public float getLngToUnityPos(float pos)
    {
        return (pos - startLng) * 10000.0f;
    }

    public void startPOIGeneration()
    {
        this.GetComponent<PlaceDownload>().getPlaceXML(this.startLat, this.startLng);

    }
}
