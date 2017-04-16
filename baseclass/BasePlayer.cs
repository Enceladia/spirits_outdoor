using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    private string player_name;
    private string player_email;
    private bool player_opt;
    private bool player_active;
    private int player_level;
    private double player_xp;
    private int player_wonBattles;
    private int player_lostBattles;
    private int player_credit;
    private int player_gold;
    private int[] player_privilege;
    private int[] player_achievement;
    private int[] player_lexSeen;
    private int[] player_lexReg;
    private List<BaseSpirit> player_spirits;
    private List<BaseItem> player_items;
    private int[] player_contacts;

    public string Player_name
    {
        get
        {
            return player_name;
        }

        set
        {
            player_name = value;
        }
    }

    public string Player_email
    {
        get
        {
            return player_email;
        }

        set
        {
            player_email = value;
        }
    }

    public bool Player_opt
    {
        get
        {
            return player_opt;
        }

        set
        {
            player_opt = value;
        }
    }

    public bool Player_active
    {
        get
        {
            return player_active;
        }

        set
        {
            player_active = value;
        }
    }

    public int Player_level
    {
        get
        {
            return player_level;
        }

        set
        {
            player_level = value;
        }
    }

    public double Player_xp
    {
        get
        {
            return player_xp;
        }

        set
        {
            player_xp = value;
        }
    }

    public int Player_wonBattles
    {
        get
        {
            return player_wonBattles;
        }

        set
        {
            player_wonBattles = value;
        }
    }

    public int Player_lostBattles
    {
        get
        {
            return player_lostBattles;
        }

        set
        {
            player_lostBattles = value;
        }
    }

    public int Player_credit
    {
        get
        {
            return player_credit;
        }

        set
        {
            player_credit = value;
        }
    }

    public int Player_gold
    {
        get
        {
            return player_gold;
        }

        set
        {
            player_gold = value;
        }
    }

    public int[] Player_privilege
    {
        get
        {
            return player_privilege;
        }

        set
        {
            player_privilege = value;
        }
    }

    public int[] Player_achievement
    {
        get
        {
            return player_achievement;
        }

        set
        {
            player_achievement = value;
        }
    }

    public int[] Player_lexSeen
    {
        get
        {
            return player_lexSeen;
        }

        set
        {
            player_lexSeen = value;
        }
    }

    public int[] Player_lexReg
    {
        get
        {
            return player_lexReg;
        }

        set
        {
            player_lexReg = value;
        }
    }

    public List<BaseSpirit> Player_spirits
    {
        get
        {
            return player_spirits;
        }

        set
        {
            player_spirits = value;
        }
    }

    public List<BaseItem> Player_items
    {
        get
        {
            return player_items;
        }

        set
        {
            player_items = value;
        }
    }

    public int[] Player_contacts
    {
        get
        {
            return player_contacts;
        }

        set
        {
            player_contacts = value;
        }
    }
}
