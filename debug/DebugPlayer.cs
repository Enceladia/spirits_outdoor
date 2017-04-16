using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugPlayer : MonoBehaviour {

    PlayerManager pm;
    BasePlayer bp;

    private void Start()
    {
        pm = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>();
        bp = pm.bp;

        bp.Player_name = "Chris";
        bp.Player_email = "example@test.com";
        bp.Player_opt = false;
        bp.Player_active = true;
        bp.Player_level = 0;
        bp.Player_xp = 0;
        bp.Player_wonBattles = 0;
        bp.Player_lostBattles = 0;
        bp.Player_credit = 0;
        bp.Player_gold = 0;
        bp.Player_privilege = new int[0];
        bp.Player_achievement = new int[0];
        bp.Player_lexSeen = new int[0];
        bp.Player_lexReg = new int[0];

        SceneManager.LoadScene("main");
    }
}
