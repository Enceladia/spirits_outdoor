using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionGUI : MonoBehaviour
{

    public GameObject poiNameGuiGo;

    Text poiNameGuiText;

    void Start()
    {
        poiNameGuiText = poiNameGuiGo.GetComponent<Text>();
    }

    public void setPoiNameGui(string name)
    {
        poiNameGuiText.text = name;
    }
}
