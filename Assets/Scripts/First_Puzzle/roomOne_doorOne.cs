using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomOne_doorOne : MonoBehaviour
{
    public PlateOne plateOne; //Making a reference to the plateOne script
    

    // Update is called once per frame
    void Update()
    {
        if (plateOne.isPressed)
        {
            transform.Translate(0, 2, 0);
        }
    }
}
