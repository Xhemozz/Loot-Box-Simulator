using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> allItems;

    public Item GetItemByID(string ID)
    {
        foreach (Item item in allItems)
            if (item.itemID == ID) { return item; }

        return null;
    }
}
