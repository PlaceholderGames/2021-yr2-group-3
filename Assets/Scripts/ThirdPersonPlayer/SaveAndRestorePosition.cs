using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndRestorePosition : MonoBehaviour
{
    void Start() //checking for a saved position for this scene and go there if there is a saved position
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (SavedPositionManager.savedPositions.ContainsKey(sceneIndex))
        {
            transform.position = SavedPositionManager.savedPositions[sceneIndex];
        }
    }

    void OnDestroy()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SavedPositionManager.savedPositions[sceneIndex] = transform.position;
    }
}
