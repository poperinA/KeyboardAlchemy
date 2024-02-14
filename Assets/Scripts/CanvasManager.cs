using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject selectGame;
    public GameObject newGame;

    public void showSelectGame()
    {
        if (newGame.activeInHierarchy)
        {
            newGame.SetActive(false);
            selectGame.SetActive(true);
        }
        else
        {
            selectGame.SetActive(true);
        }
    }

    public void showNewGame()
    {
        if (selectGame.activeInHierarchy)
        {
            selectGame.SetActive(false);
            newGame.SetActive(true);
        }
        else
        {
            newGame.SetActive(true);
        }
    }
}
