using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDownload : MonoBehaviour {

    //https://maps.googleapis.com/maps/api/place/nearbysearch/xml?location=47.453458,15.331112&radius=2000&types=cafe&key=AIzaSyD9Ol1_W18VIFMjlXqpZEnm4dnoZl4UOI0

    public string url = "https://maps.googleapis.com/maps/api/place/nearbysearch/xml?";
    public int range = 1000;

    public string key = "AIzaSyD9Ol1_W18VIFMjlXqpZEnm4dnoZl4UOI0";

    public string xml = "";

    IEnumerator getGooglePlaces(float lat, float lng)
    {
        url = url + "location=" + lat + "," + lng + "&radius=" + range + "&types=all" + "&key=" + key;

        Debug.Log(url);

        WWW www = new WWW(url);
        yield return www;

        xml = www.text;

        this.GetComponent<PlaceParser>().parsePlacesXML(xml);


    }

    public void getPlaceXML(float lat, float lng)
    {
        StartCoroutine(getGooglePlaces(lat, lng));
        
    }
}
