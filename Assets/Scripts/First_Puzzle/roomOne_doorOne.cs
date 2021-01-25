using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOne_doorOne : MonoBehaviour
{
    public roomOne_plateOne plateOne; //Making a reference to the plateOne script
    public roomOne_plateTwo plateTwo; //Making a reference to the plateTwo script
    

    // Update is called once per frame
    void Update()
    {
        if (plateOne.isPressed && plateTwo.isPressed)
        {
            transform.Translate(0, 2, 0);
        }
    }
}
