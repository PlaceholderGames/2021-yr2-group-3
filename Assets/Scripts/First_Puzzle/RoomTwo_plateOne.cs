using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTwo_plateOne : MonoBehaviour
{
    [SerializeField] //Keeps the variable private
    GameObject door;

    bool isOpened; //Door Open Boolean

    public bool isPressed; //Pressure Plate is Pressed Boolean

    private void OnTriggerEnter(Collider other)
    {
        if (isOpened == false && other.gameObject.name == "roomTwo_blockOne")
        {
            isPressed = true;
        }

    }
}

