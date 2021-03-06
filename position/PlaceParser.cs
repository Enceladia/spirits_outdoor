﻿using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class PlaceParser : MonoBehaviour
{

    private List<BasePOI> poi_list = new List<BasePOI>();

    public void parsePlacesXML(string placesXML)
    {

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(placesXML);

        XmlNodeList nodeList = xmlDoc.GetElementsByTagName("result");


        for (int i = 0; i < nodeList.Count; i++)
        {
            poi_list.Add(new BasePOI());

            foreach (XmlNode node in nodeList[i])
            {


                if (node.Name == "name")
                {
                    poi_list[i].Poi_name = node.InnerText;
                }

                if (node.Name == "vicinity")
                {
                    poi_list[i].Poi_place = node.InnerText;

                }

                if (node.Name == "geometry")
                {
                    foreach (XmlNode geometry in node)
                    {
                        if (geometry.Name == "location")
                        {
                            foreach (XmlNode location in geometry)
                            {
                                if (location.Name == "lat")
                                {
                                    poi_list[i].Poi_lat = float.Parse(location.InnerText);

                                }
                                if (location.Name == "lng")
                                {
                                    poi_list[i].Poi_lng = float.Parse(location.InnerText);
                                }
                            }
                        }
                    }
                }

                if (node.Name == "icon")
                {
                    poi_list[i].Poi_iconUrl = node.InnerText;
                }

                if (node.Name == "place_id")
                {
                    poi_list[i].Poi_id = node.InnerText;
                }

                if (node.Name == "type")
                {
                    poi_list[i].Poi_typeList.Add(node.InnerText);
                }
            }
        }

        this.GetComponent<PositionPOI>().startPOIinit(poi_list);


        /*
        foreach (BasePOI poiObj in poi_list)
        {
            Debug.Log(poiObj.poi_name);
            Debug.Log(poiObj.poi_place);

            Debug.Log(poiObj.poi_lat);
            Debug.Log(poiObj.poi_lng);

            foreach (string s in poiObj.poi_typeList)
            {
                Debug.Log(s);
            }

            Debug.Log(poiObj.poi_iconUrl);
            Debug.Log(poiObj.poi_id);

            Debug.Log("---------------------------------------------------------------------");
        }*/
    }
}
