using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPlayer : MonoBehaviour {

    public GameObject playerGo;

    // Use this for initialization
    void Start()
    {
        playerGo = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        playerGo.transform.position = new Vector3(
            this.GetComponent<PositionManager>().playerPosX, 1, this.GetComponent<PositionManager>().playerPosZ);
    }

}
