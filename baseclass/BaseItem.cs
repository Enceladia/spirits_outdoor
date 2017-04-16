using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem
{

    private string item_name;
    private int item_id;
    private Item_Types item_type;

    public enum Item_Types
    {
        MODULE,
        ESSENCE,
        SPHERE,
        SHARD,
        BODYPAINT,
        SCROLL,
        TARGET,
        PULSE
    }

    public string Item_name
    {
        get
        {
            return item_name;
        }
    }

    public int Item_id
    {
        get
        {
            return item_id;
        }
    }

    public Item_Types Item_type
    {
        get
        {
            return item_type;
        }
    }



}
