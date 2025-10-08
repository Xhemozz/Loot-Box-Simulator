using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private ItemDatabase itemDatabase;
    public Item[] inventory = new Item[4];
    private void Start()
    {
        PopulateInventory();
    }
    void PopulateInventory ()
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            inventory[i] = itemDatabase.allItems[Random.Range(0,itemDatabase.allItems.Count)];
        }
    }

    public GameObject SpawnItem()
    {
        int index = Random.Range(0, inventory.Length);
        return inventory[index].itemObject;
    }
}
