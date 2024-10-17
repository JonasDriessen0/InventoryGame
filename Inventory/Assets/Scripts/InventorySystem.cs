using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem current;
    private Dictionary<string, InventoryItem> m_itemDictionary;
    public List<InventoryItem> inventory;

    private void Awake()
    {
        current = this;
        inventory = new List<InventoryItem>();
        m_itemDictionary = new Dictionary<string, InventoryItem>();
    }

    public InventoryItem Get(InventoryItemData referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData.id, out InventoryItem value))
        {
            return value;
        }
        return null;
    }

    public void Add(InventoryItemData referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData.id, out InventoryItem value))
        {
            value.AddToStack();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            m_itemDictionary.Add(referenceData.id, newItem);
        }
        Debug.Log($"Added item: {referenceData.displayName}, Count: {m_itemDictionary[referenceData.id].stackSize}");
    }

    public void Remove(InventoryItemData referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData.id, out InventoryItem value))
        {
            value.RemoveFromStack();

            if (value.stackSize == 0)
            {
                inventory.Remove(value);
                m_itemDictionary.Remove(referenceData.id);
            }
        }
    }
    
    public void PrintInventoryContents()
    {
        Debug.Log("Inventory Contents:");
        foreach (var item in inventory)
        {
            Debug.Log($"Item: {item.data.displayName}, Count: {item.stackSize}");
        }
    }
}