using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using Debug = UnityEngine.Debug;

public class ItemDropHandler : MonoBehaviour, IDropHandler
{
    public Inventory _Inventory;

    public void OnDrop(PointerEventData eventData) {

        RectTransform invPanel = transform as RectTransform;

        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition))
        {

            IInventoryItem item = eventData.pointerDrag.gameObject.GetComponent<ItemDragHandler>().Item;
            if (item != null)
            {
                Debug.Log("Drop item");
                _Inventory.RemoveItem(item);
                item.OnDrop();
            }
        }
    }
    
}
