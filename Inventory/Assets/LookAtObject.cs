using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    [SerializeField] private float raycastLength = 5f;
    [SerializeField] private GameObject pickupIndicator;
    [SerializeField] private LayerMask raycastLayer;
    public bool lookingAtItem { get; private set; }
    public ItemObject currentItemLookingAt { get; private set; }

    private RaycastHit hit;
    private Ray ray;

    private void Update()
    {
        ray.origin = transform.position;
        ray.direction = transform.forward;

        if (Physics.Raycast(ray, out hit, raycastLength, raycastLayer))
        {
            ItemObject itemObject = hit.collider.GetComponent<ItemObject>();
            if (itemObject != null)
            {
                if (!lookingAtItem)
                {
                    lookingAtItem = true;
                    pickupIndicator.SetActive(true);
                }
                currentItemLookingAt = itemObject;
            }
            else
            {
                ResetLookAt();
            }
        }
        else
        {
            ResetLookAt();
        }
    }

    private void ResetLookAt()
    {
        if (lookingAtItem)
        {
            lookingAtItem = false;
            pickupIndicator.SetActive(false);
            currentItemLookingAt = null;
        }
    }
}