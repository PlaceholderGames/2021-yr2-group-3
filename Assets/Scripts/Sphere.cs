using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, IInventoryItem
{
    public string Name
    {

        get
        {
            return "Sphere";
        }
    }

    public Sprite _ItemImage;
    public Sprite ItemImage
    {

        get
        {
            return _ItemImage;
        }
    }
    public void OnPickup()
    {
        gameObject.SetActive(false);
    }
}

