using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectPartLevelTwo : MonoBehaviour
{
    public int collectableAmount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LevelTwoCollectableSystem.instance.ChangeAmount(collectableAmount);
        }
    }
}
