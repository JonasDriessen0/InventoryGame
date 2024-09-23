using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    [SerializeField] private float raycastLength;
    [SerializeField] private GameObject pickupIndicator;
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastLength))
        {
            if (hit.collider.gameObject.CompareTag("Item"))
            {
                pickupIndicator.SetActive(true);
                Debug.Log("sigma");
            }
            else
            {
                pickupIndicator.SetActive(false);
                Debug.Log("Sigma'nt");
            }
        }
    }
}
