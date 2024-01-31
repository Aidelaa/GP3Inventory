using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{

    public string itemName;
    public int itemID;
    public int quantity;
    
    InventorySystem inventorySystem;

    // Start is called before the first frame update
    void Start()
    {
        inventorySystem = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    }

    public void CollectItem()
    {
        Items itemToAdd = new Items(itemName, itemID, quantity);
        inventorySystem.addItem(itemToAdd);
        Destroy(gameObject);
    }
}
