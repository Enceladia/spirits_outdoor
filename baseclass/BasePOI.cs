using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dummi Klasse für generische Punkte
public class BasePOI : MonoBehaviour{
    private string poi_name;
    private string poi_place;
    private List<String> poi_typeList = new List<String>();
    private float poi_lat;
    private float poi_lng;
    private string poi_iconUrl;
    private string poi_id;

    public string Poi_name
    {
        get
        {
            return poi_name;
        }

        set
        {
            poi_name = value;
        }
    }

    public string Poi_place
    {
        get
        {
            return poi_place;
        }

        set
        {
            poi_place = value;
        }
    }

    public List<string> Poi_typeList
    {
        get
        {
            return poi_typeList;
        }

        set
        {
            poi_typeList = value;
        }
    }

    public float Poi_lat
    {
        get
        {
            return poi_lat;
        }

        set
        {
            poi_lat = value;
        }
    }

    public float Poi_lng
    {
        get
        {
            return poi_lng;
        }

        set
        {
            poi_lng = value;
        }
    }

    public string Poi_iconUrl
    {
        get
        {
            return poi_iconUrl;
        }

        set
        {
            poi_iconUrl = value;
        }
    }

    public string Poi_id
    {
        get
        {
            return poi_id;
        }

        set
        {
            poi_id = value;
        }
    }
}
