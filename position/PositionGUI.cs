using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionGUI : MonoBehaviour {

    public GameObject poiNameGuiGo;
    public GameObject poiDistanceGo;

    Text poiNameGuiText;
    Text poiDistanceGuiText;
    
	void Start () {
        poiNameGuiText = poiNameGuiGo.GetComponent<Text>();
        poiDistanceGuiText = poiDistanceGo.GetComponent<Text>();
    }

    public void setPoiNameGui(string name, float distance)
    {
        poiNameGuiText.text = name;
        poiDistanceGuiText.text = distance.ToString();
    }
}
