using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    public bool isNewGame;
    public bool isSettings;
    public bool isQuit;

    public void OnMouseUp()
    {
        if (isNewGame)
        {
            SceneManager.LoadScene(1);
        }
        else if (isSettings)
        {
            SceneManager.LoadScene(2);
        }
        else if (isQuit)
        {
            Application.Quit();
        }
    }
}
