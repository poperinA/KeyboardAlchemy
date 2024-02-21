using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject welcomePanel;
    public Button startTutorialButton;

    private void Start()
    {
        // Show the welcome panel when the scene starts
        if (welcomePanel != null)
            welcomePanel.SetActive(true);
    }

    public void StartTutorial()
    {
        // Add logic to start the tutorial here
        // For example, you can hide the welcome panel and proceed to the next step
        if (welcomePanel != null)
            welcomePanel.SetActive(false);

        // Implement the next step of the tutorial here
    }
}
