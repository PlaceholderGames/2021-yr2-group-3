using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableSystem : MonoBehaviour
{
    public GameObject partsCollectedText;
    public static int partsAmount = 0;

    void Update()
    {
        partsCollectedText.GetComponent<Text>().text = "PARTS COLLECTED: " + partsAmount;
        DontDestroyOnLoad(transform.gameObject); //Objects persists on scene loading
    }
}
