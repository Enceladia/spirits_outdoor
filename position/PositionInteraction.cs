using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionInteraction : MonoBehaviour {

    void FixedUpdate()
    {
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
                        GetComponent<PositionGUI>().setPoiNameGui(hit.transform.parent.GetComponent<BasePOI>().Poi_name);
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log(" You just hit " + hit.collider.gameObject.name);

                if (hit.collider.tag.Equals("POI_prefab"))
                {

                    GameObject.FindGameObjectWithTag("SceneManager").
                        GetComponent<PositionGUI>().setPoiNameGui(
                        hit.transform.parent.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("POI_prefab"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("POI_prefab"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }


    [System.Obsolete("Distance don´t has to get calculated, solved with colliders")]
    private float calculateDebugDistance(Vector3 playerPos, Vector3 otherPos)
    {
        float dist = Vector3.Distance(otherPos, playerPos);
        return dist;
    }
}
