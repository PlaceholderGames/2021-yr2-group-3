using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOne_DoorThree : MonoBehaviour
{
    public RoomOne_plateOne plateOne; //Making a reference to the plateOne script
    public RoomOne_plateTwo plateTwo; //Making a reference to the plateTwo script
    public RoomOne_plateThree plateThree; //Making a reference to the plateThree script

    // Update is called once per frame
    void Update()
    {
        if (plateOne.isPressed && plateTwo.isPressed && plateThree.isPressed)
        {
            transform.Translate(0, 2, 0);
        }
    }
}
