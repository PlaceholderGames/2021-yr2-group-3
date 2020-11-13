﻿using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Inventory Inventory;

    public GameObject MessagePanel;
    // Start is called before the first frame update
    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
        Inventory.ItemRemoved += Inventory_ItemRemoved;

    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e) {

        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach (Transform slot in inventoryPanel) {

            //Border image
            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            ItemDragHandler itemDragHandler = imageTransform.GetComponent<ItemDragHandler>();

            //Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();

            //We found the empty slot
            if (!image.enabled) {
                image.enabled = true;
                image.sprite = e.Item.Image;

                //Store a reference to the item
                itemDragHandler.Item = e.Item;

                break;
            }
        
        }
    }

    private void Inventory_ItemRemoved(object sender, InventoryEventArgs e)
    {

        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach (Transform slot in inventoryPanel)
        {

            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            ItemDragHandler itemDragHandler = imageTransform.GetComponent<ItemDragHandler>();


            //We found the item in the UI
            if (itemDragHandler.Item.Equals(e.Item))
            {
                image.enabled = false;
                image.sprite = null;
               // itemDragHandler.Item = null;

                break;
            }

        }
    }
    public void OpenMessagePanel(string text){

        MessagePanel.SetActive(true);
    }

    public void CloseMessagePanel() {
        MessagePanel.SetActive(false);
    }
}
