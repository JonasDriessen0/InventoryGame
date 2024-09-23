using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    [SerializeField] private float raycastLength;
    [SerializeField] private GameObject pickupIndicator;
    [SerializeField] private LayerMask raycastLayer;
    public bool lookingAtItem;
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastLength, raycastLayer))
        {
            if (hit.collider.gameObject.CompareTag("Item"))
            {
                lookingAtItem = true;
                pickupIndicator.SetActive(true);
            }
            else
            {
                lookingAtItem = false;
                pickupIndicator.SetActive(false);
            }
        }
    }
}
