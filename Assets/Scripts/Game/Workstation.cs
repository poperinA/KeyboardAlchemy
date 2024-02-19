using UnityEngine;

public class Workstation : MonoBehaviour
{
    public GameObject BG;
    public GameObject Cases;
    public GameObject Plates;
    public GameObject PCBs;
    public GameObject Keycaps;
    public GameObject Switches;

    // Method to hide all panels except the default one (BG)
    void HideAllPanels()
    {
        Cases.SetActive(false);
        Plates.SetActive(false);
        PCBs.SetActive(false);
        Keycaps.SetActive(false);
        Switches.SetActive(false);
    }

    public void DisplayCases()
    {
        HideAllPanels();
        Cases.SetActive(true);
    }

    public void DisplayPlates()
    {
        HideAllPanels();
        Plates.SetActive(true);
    }

    public void DisplayPCBs()
    {
        HideAllPanels();
        PCBs.SetActive(true);
    }

    public void DisplayKeycaps()
    {
        HideAllPanels();
        Keycaps.SetActive(true);
    }

    public void DisplaySwitches()
    {
        HideAllPanels();
        Switches.SetActive(true);
    }
}
