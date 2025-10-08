using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Inventory/Item", order = 1)]
public class Item : ScriptableObject
{
    public string itemName;
    public string itemID;
    public GameObject itemObject;
}
