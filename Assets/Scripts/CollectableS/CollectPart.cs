using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPart : MonoBehaviour
{
    public int collectableAmount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            CollectableSystem.instance.ChangeAmount(collectableAmount);
        }
    }
}
