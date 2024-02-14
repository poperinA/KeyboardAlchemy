using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{

    public GameObject Megan;
    public GameObject David;

    public void showMegan()
    {
        if(David.activeInHierarchy)
        {
            David.SetActive(false);
            Megan.SetActive(true);
        }
        else
        {
            Megan.SetActive(true);
        }
    }

    public void showDavid()
    {
        if (Megan.activeInHierarchy)
        {
            Megan.SetActive(false);
            David.SetActive(true);
        }
        else
        {
            David.SetActive(true);
        }
    }
}
