using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwoCollectableSystem : MonoBehaviour
{
    public static LevelTwoCollectableSystem instance;
    public int collectableAmount;
    public Text text;
    public bool collectedAll;

    private void Start()
    {
        if (instance == null)
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
        if (collectableAmount == 4)
        {
            collectedAll = true;
        }
        else collectedAll = false;
    }

}
