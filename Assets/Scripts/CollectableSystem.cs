using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableSystem : MonoBehaviour
{
    public GameObject partsCollectedText;
    public int partsAmount;

    void OnTriggerEnter(Collider other)
    {

        partsAmount += 1;
        partsCollectedText.GetComponent<Text>().text = "PARTS COLLECTED: " + partsAmount;
        Destroy(gameObject);
    }
}
