using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public GameObject Megan;
    public GameObject David;

    public GameObject MeganImage;
    public GameObject DavidImage;

    public TextMeshProUGUI playerNameText;

    public GameObject Options;
    public GameObject Settings;
    public GameObject AreYouSure;

    public PlayerController playerControllerM;
    public PlayerController playerControllerD;

    public GameObject gameUI;
    public GameObject WorkstationUI;
    public GameObject PCSetupUI;

    public GameObject TutorialPanel;

    private void Start()
    {
        // Retrieve player name and gender from PlayerPrefs and display them
        string playerName = PlayerPrefs.GetString("PlayerName", "DefaultPlayerName");
        string playerGender = PlayerPrefs.GetString("PlayerGender", "DefaultPlayerGender");

        // Set player name text
        playerNameText.text = playerName;

        // Activate the appropriate character and character image based on player's gender
        if (playerGender == "Female")
        {
            Megan.SetActive(true);
            MeganImage.SetActive(true);
            David.SetActive(false);
            DavidImage.SetActive(false);
        }
        else if (playerGender == "Male")
        {
            David.SetActive(true);
            DavidImage.SetActive(true);
            Megan.SetActive(false);
            MeganImage.SetActive(false);
        }
        else
        {
            Debug.Log("Gender not found");
        }
    }

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
        if (Options.activeInHierarchy == true || AreYouSure.activeInHierarchy == true 
        || WorkstationUI.activeInHierarchy == true || PCSetupUI.activeInHierarchy == true)
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

    public void BackToGameW()
    {
        if (WorkstationUI != null)
        {
            WorkstationUI.SetActive(false);
            gameUI.SetActive(true);
            Resume();

            if (TutorialPanel.activeInHierarchy)
            {
                TutorialPanel.SetActive(false);
            }
        }
    }

    public void BackToGamePC()
    {
        if (PCSetupUI != null)
        {
            PCSetupUI.SetActive(false);
            gameUI.SetActive(true);
            Resume();
        }
    }
}
