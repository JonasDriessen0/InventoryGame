using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;

    private void Start()
    {
        if (referenceItem == null)
        {
            Debug.LogError("InventoryItemData not assigned to ItemObject: " + gameObject.name);
        }
    }

    public void OnhandlePickupitem()
    {
        if (referenceItem != null)
        {
            InventorySystem.current.Add(referenceItem);
            Debug.Log($"Picked up item: {referenceItem.displayName}");
            InventorySystem.current.PrintInventoryContents();
            Destroy(gameObject);
        }
        else
        {
            Debug.LogError("Attempted to pick up item with no referenceItem assigned: " + gameObject.name);
        }
    }
}