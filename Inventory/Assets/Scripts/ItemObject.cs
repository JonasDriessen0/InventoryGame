using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;

    public void OnhandlePickupitem()
    {
        InventorySystem.current.Add(referenceItem);
        Destroy(gameObject);
    }

    private void Update()
    {
    }
}
