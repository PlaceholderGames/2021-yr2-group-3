using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButtons : MonoBehaviour
{
    public int index;
    public int indexTwo;
    public bool isCredits;
    public bool isNextPage;
    public bool isLastPage;

    public void OnMouseUp()
    {
        if (isCredits)
        {
            SceneManager.LoadScene(index); //Loading level using build index
        }
        else if (isNextPage)
        {
            SceneManager.LoadScene(index);
        }
        else if (isLastPage)
        {
            SceneManager.LoadScene(indexTwo);
        }
    }


}
