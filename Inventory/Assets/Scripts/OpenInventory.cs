using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private MouseLook mouseLook;
    private bool isInventoryEnabled;

    private void Start()
    {
        inventory.SetActive(false);
        isInventoryEnabled = false;
    }

    private void Update()
    {
        if (!isInventoryEnabled && Input.GetKeyDown(KeyCode.Escape))
        {
            inventory.SetActive(true);
            mouseLook.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            isInventoryEnabled = true;
        }
        else if (isInventoryEnabled && Input.GetKeyDown(KeyCode.Escape))
        {
            inventory.SetActive(false);
            mouseLook.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            isInventoryEnabled = false;
        }
    }
}
