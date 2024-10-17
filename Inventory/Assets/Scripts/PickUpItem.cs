using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] private LookAtObject lookAtObject;

    private void Update()
    {
        if (lookAtObject.lookingAtItem && Input.GetKeyDown(KeyCode.E))
        {
            PickUpLookedAtItem();
        }
    }

    private void PickUpLookedAtItem()
    {
        if (lookAtObject.currentItemLookingAt != null)
        {
            lookAtObject.currentItemLookingAt.OnhandlePickupitem();
            Debug.Log($"Picked up item: {lookAtObject.currentItemLookingAt.referenceItem.displayName}");
        }
        else
        {
            Debug.LogWarning("Tried to pick up item, but no item is being looked at.");
        }
    }
}