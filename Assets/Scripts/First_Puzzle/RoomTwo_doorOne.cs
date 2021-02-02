using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTwo_doorOne : MonoBehaviour
{
    public RoomTwo_plateOne plateOne; //Making a reference to the plateOne script
    public RoomTwo_PlateTwo plateTwo; //Making a reference to the plateTwo script

    //Update is called once per frame

    private void Update()
    {
        if (plateOne.isPressed && plateTwo.isPressed)
        {
            transform.Translate(0, 2, 0);
        }
    }
}
