using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCSetup : MonoBehaviour
{
    public GameObject Items;
    public GameObject Marketplace;
    public GameObject Buy;
    public GameObject BackBtn;
    public GameObject boughtBundle;
    public Button Bundle;

    public bool bought = false;

    public void Update()
    {
        if(bought == true)
        {
            boughtBundle.SetActive(true);
            Bundle.interactable = false;
        }
        else
        {
            boughtBundle.SetActive(false);
        }
    }
    public void openMarketplace()
    {
        Items.SetActive(false);
        BackBtn.SetActive(false);
        Marketplace.SetActive(true);
    }

    public void openBuy()
    {
        Buy.SetActive(true);
    }

    public void Yes()
    {
        bought = true; 
        Buy.SetActive(false);
    }

    public void No()
    {
        Buy.SetActive(false);
    }

    public void X()
    {
        Marketplace.SetActive(false);
        Buy.SetActive(false);

        Items.SetActive(true);
        BackBtn.SetActive(true);
    }
}
