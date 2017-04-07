using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    public string username = "";
    public string user_email = "";
    public bool user_opt = false;
    public bool user_active = false;
    public int user_level = 0;
    public double user_xp = 0.0f;
    public int user_credit = 0;
    public int user_gold = 0;
    public int[] user_privilege;
    public int[] user_achievement;
    public int[] user_lex;
    public string[] user_spirits;
    public int[] user_items;
}
