using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPOI : MonoBehaviour {

    //private List<GameObject> poiGoList = new List<GameObject>();

	// Use this for initialization
	void Start () {
        //startPOIinit();
	}
	
	public void startPOIinit(List<BasePOI> poiList)
    {
        //ToDo: Add functions to differenciate between place types
        //ToDo: If updated List arrives, delete POI´s that are far away from the player and add new with new lat/lng
        foreach (BasePOI bp in poiList)
        {
            GameObject instance = Instantiate(Resources.Load("POI_prefab", typeof(GameObject))) as GameObject;
            instance.transform.position = new Vector3(this.GetComponent<PositionManager>().getLatToUnityPos(bp.poi_lat), 0, this.GetComponent<PositionManager>().getLngToUnityPos(bp.poi_lng));
            instance.transform.GetChild(0).GetComponent<TextMesh>().text = bp.poi_name;
        }
    }
}
