using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    //new object from the dictionary constructor
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id, string title, string description, Dictionary<string, int> stats)
    {
        //instance field equals the paramenter passed in
        this.id = id;
        this.title = title;
        this.description = description;
        //this.icon = icon;
        this.icon = Resources.Load<Sprite>("Items/" + title); ;
        this.stats = stats;
    }

    // Clone Creator
    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = item.icon;
        this.stats = item.stats;
    }
}
