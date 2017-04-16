using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public BasePlayer bp;

    public void Awake()
    {
        bp = new BasePlayer();
    }

}
