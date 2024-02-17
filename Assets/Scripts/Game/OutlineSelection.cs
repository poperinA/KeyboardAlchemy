using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OutlineSelection : MonoBehaviour
{
    private Transform highlight;
    private Transform selection;
    private RaycastHit raycastHit;

    public GameObject GameUI;
    public GameObject WorkstationUI;
    public GameObject PCSetupUI;

    public PlayerController playerControllerM;
    public PlayerController playerControllerD;

    void Update()
    {
        // Highlight
        if (highlight != null)
        {
            highlight.gameObject.GetComponent<Outline>().enabled = false;
            highlight = null;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray, out raycastHit))
        {
            highlight = raycastHit.transform;
            if (highlight.CompareTag("Selectable") && highlight != selection)
            {
                if (highlight.gameObject.GetComponent<Outline>() != null)
                {
                    highlight.gameObject.GetComponent<Outline>().enabled = true;
                }
                else
                {
                    Outline outline = highlight.gameObject.AddComponent<Outline>();
                    outline.enabled = true;
                    highlight.gameObject.GetComponent<Outline>().OutlineColor = Color.magenta;
                    highlight.gameObject.GetComponent<Outline>().OutlineWidth = 7.0f;
                }
            }
            else
            {
                highlight = null;
            }
        }

        // Selection
        if (Input.GetMouseButtonDown(0))
        {
            if (raycastHit.transform != null)
            {
                if (raycastHit.transform.CompareTag("Selectable"))
                {
                    if (raycastHit.transform.name == "Workstation")
                    {
                        ActivateWorkstation();
                    }
                    else if (raycastHit.transform.name == "PC")
                    {
                        ActivatePCSetup();
                    }
                }
            }
        }
    }

    public void ActivateWorkstation()
    {
        // Disable GameUI and enable WorkstationUI
        GameUI.SetActive(false);
        WorkstationUI.SetActive(true);
    }

    public void ActivatePCSetup()
    {
        // Disable GameUI and enable PCSetupUI
        GameUI.SetActive(false);
        PCSetupUI.SetActive(true);
    }
}
