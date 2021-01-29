using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//blueprint (class) for the craftrecipe
public class CraftRecipe
{
    //array of items
    public int[] requiredItems;
    public int itemToCraft;

    public CraftRecipe(int itemToCraft, int[] requiredItems)
    {
        this.requiredItems = requiredItems;
        this.itemToCraft = itemToCraft;
    }
}
