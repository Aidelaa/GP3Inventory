using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class serializableValuePair<TKey, TValue>
{
    public TKey Key;
    public TValue Value;

    public serializableValuePair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}

[System.Serializable]
public class InventorySystem : MonoBehaviour
{
    [SerializeField]
    private Dictionary<int, Items> inventory = new Dictionary<int, Items>();
    [SerializeField]
    List<serializableValuePair<int, Items>> inventoryList = new List<serializableValuePair<int, Items>>();

    public void syncListWithDictionary()
    {
        inventoryList.Clear();
        foreach (var pair in inventory)
        {
            inventoryList.Add (new serializableValuePair<int, Items>(pair.Key, pair.Value));
        }
    }

    public void addItem(Items item)
    {
        if (inventory.ContainsKey(item.ID))
        {
            //upd quantity
        }
        else
        {
            inventory.Add(item.ID, item);
        }
        syncListWithDictionary();
    }

    public bool removeItem(int itemID)
    {
        bool _remove = inventory.Remove(itemID);
        if (_remove)
        {
            syncListWithDictionary();
        }
        return _remove; 
    }

    public bool checkItem(int itemID)
    {
        return inventory.ContainsKey(itemID);
    }
}
