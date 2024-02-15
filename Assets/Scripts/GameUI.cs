using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject Options;
    public GameObject Settings;
    public GameObject AreYouSure;

    public PlayerController playerControllerM;
    public PlayerController playerControllerD;

    public void Update()
    {
        PauseCheck();
    }
    public void ToggleOptions()
    {
        if (Options != null)
        {
            bool isActive = Options.activeSelf;

            Options.SetActive(!isActive);
        }
    }

    public void PauseCheck()
    {
        if (Options.activeInHierarchy == true || AreYouSure.activeInHierarchy == true)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    private void Pause()
    {

        if (playerControllerM != null && playerControllerM.enabled == true)
        {
            playerControllerM.enabled = false;
        }

        if (playerControllerD != null && playerControllerD.enabled == true)
        {
            playerControllerD.enabled = false;
        }
    }

    private void Resume()
    {

        if (playerControllerM != null && playerControllerM.enabled == false)
        {
            playerControllerM.enabled = true;
        }

        if (playerControllerD != null && playerControllerD.enabled == false)
        {
            playerControllerD.enabled = true;
        }
    }

    public void OpenSettings()
    {
        if (Settings != null)
        {
            Settings.SetActive(true);
        }
    }

    public void CloseSettings()
    {
        if (Settings != null)
        {
            Settings.SetActive(false);
        }
    }

    public void OpenAreYouSure()
    {
        if (AreYouSure != null)
        {
            Options.SetActive(false);
            AreYouSure.SetActive(true);
        }
    }

    public void CloseAreYouSure()
    {
        if (AreYouSure != null)
        {
            AreYouSure.SetActive(false);
            Options.SetActive(true);
        }
    }
}
