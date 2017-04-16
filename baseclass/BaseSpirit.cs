using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpirit
{

    private string spirit_name;
    private int spirit_id;

    private float base_health;
    private float base_energy;
    private float base_strength;
    private float base_defense;
    private float base_intellect;
    private float base_willpower;
    private float base_speed;

    private float cur_health;
    private float cur_energy;
    private float cur_strength;
    private float cur_defense;
    private float cur_intellect;
    private float cur_willpower;
    private float cur_speed;

    private Spirit_Types spirit_type1;
    private Spirit_Types spirit_type2;

    public enum Spirit_Types {
        WATER,
        FIRE,
        EARTH,
        AIR,
        BEAST,
        PLANT,
        INSECT,
        DRAGON
    }

    public string Spirit_name
    {
        get
        {
            return spirit_name;
        }
    }

    public int Spirit_id
    {
        get
        {
            return spirit_id;
        }
    }

    public float Base_health
    {
        get
        {
            return base_health;
        }
    }

    public float Base_energy
    {
        get
        {
            return base_energy;
        }
    }

    public float Base_strength
    {
        get
        {
            return base_strength;
        }
    }

    public float Base_defense
    {
        get
        {
            return base_defense;
        }
    }

    public float Base_intellect
    {
        get
        {
            return base_intellect;
        }
    }

    public float Base_willpower
    {
        get
        {
            return base_willpower;
        }
    }

    public float Base_speed
    {
        get
        {
            return base_speed;
        }
    }

    public float Cur_health
    {
        get
        {
            return cur_health;
        }

        set
        {
            cur_health = value;
        }
    }

    public float Cur_energy
    {
        get
        {
            return cur_energy;
        }

        set
        {
            cur_energy = value;
        }
    }

    public float Cur_strength
    {
        get
        {
            return cur_strength;
        }

        set
        {
            cur_strength = value;
        }
    }

    public float Cur_defense
    {
        get
        {
            return cur_defense;
        }

        set
        {
            cur_defense = value;
        }
    }

    public float Cur_intellect
    {
        get
        {
            return cur_intellect;
        }

        set
        {
            cur_intellect = value;
        }
    }

    public float Cur_willpower
    {
        get
        {
            return cur_willpower;
        }

        set
        {
            cur_willpower = value;
        }
    }

    public float Cur_speed
    {
        get
        {
            return cur_speed;
        }

        set
        {
            cur_speed = value;
        }
    }

    public Spirit_Types Spirit_type1
    {
        get
        {
            return spirit_type1;
        }
    }

    public Spirit_Types Spirit_type2
    {
        get
        {
            return spirit_type2;
        }
    }
}
