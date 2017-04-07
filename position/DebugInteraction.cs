﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInteraction : MonoBehaviour {
    
	void FixedUpdate () {
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(" You just hit " + hit.collider.gameObject.name);

                if (hit.collider.tag.Equals("POI_prefab"))
                {

                    GameObject.FindGameObjectWithTag("SceneManager").
                        GetComponent<PositionGUI>().setPoiNameGui(hit.
                        transform.parent.GetComponent<BasePOI>().poi_name);
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(" You just hit " + hit.collider.gameObject.name);

                if (hit.collider.tag.Equals("POI_prefab"))
                {

                    GameObject.FindGameObjectWithTag("SceneManager").
                        GetComponent<PositionGUI>().setPoiNameGui(hit.
                        transform.parent.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text);
                }
            }
        }
    }
}