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
            AudioManager.Instance.PlaySFX("BtnClick");
        }
        else
        {
            selectGame.SetActive(true);
            AudioManager.Instance.PlaySFX("BtnClick");
        }
    }

    public void showNewGame()
    {
        if (selectGame.activeInHierarchy)
        {
            selectGame.SetActive(false);
            newGame.SetActive(true);
            AudioManager.Instance.PlaySFX("BtnClick");
        }
        else
        {
            newGame.SetActive(true);
            AudioManager.Instance.PlaySFX("BtnClick");
        }
    }
}
