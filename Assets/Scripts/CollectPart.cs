using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPart : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        CollectableSystem.partsAmount += 1;
        Destroy(gameObject);
    }
}
