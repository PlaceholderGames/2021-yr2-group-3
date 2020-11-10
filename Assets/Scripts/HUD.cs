using System.Collections;
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

    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e) {

        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach (Transform slot in inventoryPanel) {

            //Border image
            Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();


            //We found the empty slot
            if (!image.enabled) {
                image.enabled = true;
                image.sprite = e.Item.ItemImage;

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
