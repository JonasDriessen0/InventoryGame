using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private MouseLook mouseLook;
    [SerializeField] private GameObject hotbarBackground;
    private bool isInventoryEnabled;

    private void Start()
    {
        inventory.SetActive(false);
        isInventoryEnabled = false;
    }

    private void Update()
    {
        if (!isInventoryEnabled && Input.GetKeyDown(KeyCode.Tab))
        {
            inventory.SetActive(true);
            mouseLook.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            isInventoryEnabled = true;
            hotbarBackground.SetActive(false);
        }
        else if (isInventoryEnabled && Input.GetKeyDown(KeyCode.Tab))
        {
            inventory.SetActive(false);
            mouseLook.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            isInventoryEnabled = false;
            hotbarBackground.SetActive(true);
        }
    }
}
