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
            instance.transform.position = new Vector3(this.GetComponent<PositionManager>().getLatToUnityPos(bp.poi_lat), 0, this.GetComponent<PositionManager>().getLngToUnityPos(bp.poi_lng));
            instance.transform.GetChild(0).GetComponent<TextMesh>().text = bp.poi_name;
            instance.AddComponent<BasePOI>();

            instance.GetComponent<BasePOI>().poi_name = bp.poi_name;
            instance.GetComponent<BasePOI>().poi_place = bp.poi_place;
            instance.GetComponent<BasePOI>().poi_lat = bp.poi_lat;
            instance.GetComponent<BasePOI>().poi_lng = bp.poi_lng;
            instance.GetComponent<BasePOI>().poi_typeList = bp.poi_typeList;
            instance.GetComponent<BasePOI>().poi_iconUrl = bp.poi_iconUrl;
            instance.GetComponent<BasePOI>().poi_id = bp.poi_id;
        }
    }
}
