using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPOI : MonoBehaviour
{

    public void startPOIinit(List<BasePOI> poiList)
    {
        //ToDo: Add functions to differenciate between place types
        //ToDo: If updated List arrives, delete POI´s that are far away from the player and add new with new lat/lng
        foreach (BasePOI bp in poiList)
        {
            GameObject instance = Instantiate(Resources.Load("POI_prefab", typeof(GameObject))) as GameObject;
            instance.transform.position = new Vector3(this.GetComponent<PositionManager>().getLatToUnityPos(bp.Poi_lat), 0, this.GetComponent<PositionManager>().getLngToUnityPos(bp.Poi_lng));
            instance.transform.GetChild(0).GetComponent<TextMesh>().text = bp.Poi_name;

            instance.AddComponent<BasePOI>();

            instance.GetComponent<BasePOI>().Poi_name = bp.Poi_name;
            instance.GetComponent<BasePOI>().Poi_place = bp.Poi_place;
            instance.GetComponent<BasePOI>().Poi_lat = bp.Poi_lat;
            instance.GetComponent<BasePOI>().Poi_lng = bp.Poi_lng;
            instance.GetComponent<BasePOI>().Poi_typeList = bp.Poi_typeList;
            instance.GetComponent<BasePOI>().Poi_iconUrl = bp.Poi_iconUrl;
            instance.GetComponent<BasePOI>().Poi_id = bp.Poi_id;
        }
    }
}
