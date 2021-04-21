using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneControl : MonoBehaviour
{

    public int index;
    public GameObject collectableSystem;
    private LevelOneCollectableSystem collect_script;

    private void Start()
    {
        collect_script = collectableSystem.GetComponent<LevelOneCollectableSystem>();
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (collect_script.collectedAll == true))
        {
            SceneManager.LoadScene(index); //Load level using build index
        }
    }
}
