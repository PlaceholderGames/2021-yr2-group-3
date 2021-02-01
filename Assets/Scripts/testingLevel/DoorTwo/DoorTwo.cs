using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTwo : MonoBehaviour
{
    public PlateOne plateOne; //Making a reference to the plateOne script
    public PlateTwo plateTwo; //Making a reference to the plateTwo script
    public PlateThree plateThree; //Making a reference to the plateThree script

    // Update is called once per frame
    void Update()
    {
        if (plateOne.isPressed && plateTwo.isPressed && plateThree.isPressed)
        {
            transform.Translate(0, 2, 0);
        }
    }
}
