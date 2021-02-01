using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOne_doorOne : MonoBehaviour
{
    public RoomOne_plateThree plateThree; //Making a reference to the plateTwo script
    

    // Update is called once per frame
    void Update()
    {
        if (plateThree.isPressed)
        {
            transform.Translate(0, 2, 0);
        }
    }
}
