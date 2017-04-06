using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugCanvas : MonoBehaviour {

    public GameObject playerPosxGo;
    public GameObject playerPoszGo;

    public GameObject poi_countGo;
    public GameObject xmlUrlGo;

    Text poi_countText;
    Text xmlUrlText;

    Text playerPosxText;
    Text playerPoszText;

    // Use this for initialization
    void Start()
    {
        playerPosxText = playerPosxGo.GetComponent<Text>();
        playerPoszText = playerPoszGo.GetComponent<Text>();

        poi_countText = poi_countGo.GetComponent<Text>();
        xmlUrlText = xmlUrlGo.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosxText.text = GameObject.FindGameObjectWithTag("Player").
            transform.position.x.ToString();
        playerPoszText.text = GameObject.FindGameObjectWithTag("Player").
            transform.position.z.ToString();

        //playerPosxText.text = this.GetComponent<PositionManager>().startLat.ToString();
        //playerPoszText.text = this.GetComponent<PositionManager>().startLng.ToString();

        int x = 0;

        foreach (GameObject test in GameObject.FindGameObjectsWithTag("POI_prefab"))
        {
            x++;
        }

        poi_countText.text = "Prefab Count: " + x;

        //xmlUrlText.text = this.GetComponent<PlaceDownload>().xml;
        xmlUrlText.text = this.GetComponent<PlaceDownload>().url;
    }
}
