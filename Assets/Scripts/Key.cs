﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour , IInventoryItem
{

    public string Name {
        get {
            return "Key";

        }
    }

    public Sprite _ItemImage;

    public Sprite ItemImage
    {
        get {
            return _ItemImage;
        }

    }

    public void OnPickup() {

        gameObject.SetActive(false);
    }
}
