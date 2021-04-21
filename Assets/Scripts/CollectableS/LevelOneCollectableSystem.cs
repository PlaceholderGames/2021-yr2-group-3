using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelOneCollectableSystem : MonoBehaviour
{
    public static LevelOneCollectableSystem instance;
    public int collectableAmount;
    public Text text;
    public bool collectedAll;

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

    public void Update()
    {
        if (collectableAmount == 5)
        {
            collectedAll = true;
        }
        else collectedAll = false;
    }

}
