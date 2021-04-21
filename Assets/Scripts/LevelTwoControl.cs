using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwoControl : MonoBehaviour
{
    public int index;
    public GameObject collectableSystem;
    private LevelTwoCollectableSystem collect_script;

    private void Start()
    {
        collect_script = collectableSystem.GetComponent<LevelTwoCollectableSystem>();
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (collect_script.collectedAll == true))
        {
            SceneManager.LoadScene(index); //Load level using build index
        }
    }
}
