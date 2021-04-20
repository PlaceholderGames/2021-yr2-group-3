using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableSystem : MonoBehaviour
{
    public static CollectableSystem instance;
    int collectableAmount;
    public Text text;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeAmount(int collectableValue)
    {
        collectableAmount += collectableValue;
        text.text = "x" + collectableAmount.ToString();
    }
  
}
