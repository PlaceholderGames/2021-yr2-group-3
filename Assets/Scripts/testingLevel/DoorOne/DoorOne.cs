using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOne : MonoBehaviour
{
    [SerializeField] //Keeps the variable private
    GameObject door;

    bool isOpened; //Checking if door is open

    private void OnTriggerEnter(Collider other)
    {
        if (isOpened == false && other.gameObject.name == "BlockOne") //Checks that the door is closed and the object on the pressure plate is the pushable block
        {
            door.transform.position += new Vector3(0, 4, 0);  //Lifting door up to allow player through 
            isOpened = true; //Sets door to be opened
        }
       
    }
}
