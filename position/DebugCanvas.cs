using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugCanvas : MonoBehaviour {

    public GameObject playerPosxGo;
    public GameObject playerPoszGo;

    Text playerPosxText;
    Text playerPoszText;

    // Use this for initialization
    void Start()
    {
        playerPosxText = playerPosxGo.GetComponent<Text>();
        playerPoszText = playerPoszGo.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosxText.text = GameObject.FindGameObjectWithTag("Player").
            transform.position.x.ToString();
        playerPoszText.text = GameObject.FindGameObjectWithTag("Player").
            transform.position.z.ToString();
    }
}
