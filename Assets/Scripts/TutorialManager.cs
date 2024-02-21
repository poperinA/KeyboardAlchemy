using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    // Stage 1 screens
    public GameObject Stage1Screen1;
    public GameObject Stage1Screen2;
    public GameObject Stage1Screen3;
    public GameObject Stage1Screen4;
    public GameObject Stage1Screen5;
    public GameObject Stage1Screen6;
    public GameObject Stage1Screen7;
    public GameObject Stage1Screen8;

    // Stage 2 screens
    public GameObject Stage2Screen1;
    public GameObject Stage2Screen2;
    public GameObject Stage2Screen3;
    public GameObject Stage2Screen4;
    public GameObject Stage2Screen5;

    public GameObject WorkstationUI;
    public bool Stage2Done = false;

    // Stage 3 screens
    public GameObject Stage3Screen1;
    public GameObject Stage3Screen2;
    public GameObject Stage3Screen3;
    public GameObject Stage3Screen4;
    public GameObject Stage3Screen5;

    public GameObject PCSetupUI;
    public bool Stage3Done = false;

    public GameObject Marketplace;
    public bool marketplace = false;

    public GameObject Tick;
    public bool bought = false;
    public bool next = false;


    // Stage 4 screens
    public GameObject Stage4Screen1;
    public GameObject Stage4Screen2;
    public GameObject Stage4Screen3;
    public GameObject Stage4Screen4;
    public GameObject Stage4Screen5;
    public GameObject Stage4Screen6;
    public GameObject Stage4Screen7;
    public GameObject Stage4Screen8;

    public GameObject pic1;
    public GameObject pic2;
    public GameObject pic3;
    public GameObject pic4;
    public GameObject pic5;

    private bool stage4Screen7Shown = false;

    public GameObject GameUI;
    public bool Stage4End = false;

    private void Start()
    {
        // Start with Stage 1, Screen 1
        ShowStage1Screen1();
    }

    private void Update()
    {
        if (WorkstationUI.activeInHierarchy && Stage2Done == false)
        {
            ShowStage2Screen1();
        }

        if (PCSetupUI.activeInHierarchy && Stage3Done == false)
        {
            ShowStage3Screen1();
        }

        if (Marketplace.activeInHierarchy && marketplace == false)
        {
            ShowStage3Screen3();
        }

        if (Tick.activeInHierarchy && bought == false)
        {
            ShowStage3Screen5();
        }

        if(WorkstationUI.activeInHierarchy && bought == true && next == false)
        {
            ShowStage4Screen1();
            next = true;
        }

        if (pic1.activeInHierarchy)
        {
            SetActiveAndDisableOthers(Stage4Screen3);
        }

        if (pic2.activeInHierarchy)
        {
            SetActiveAndDisableOthers(Stage4Screen4);
        }

        if (pic3.activeInHierarchy)
        {
            SetActiveAndDisableOthers(Stage4Screen5);
        }

        if (pic4.activeInHierarchy)
        {
            SetActiveAndDisableOthers(Stage4Screen6);
        }

        if (pic5.activeInHierarchy && !stage4Screen7Shown)
        {
            SetActiveAndDisableOthers(Stage4Screen7);
            stage4Screen7Shown = true;
            pic4.SetActive(false);
            pic3.SetActive(false);
            pic2.SetActive(false);
            pic1.SetActive(false);
        }



        if (GameUI.activeInHierarchy && Stage4End == true)
        {
            ShowStage4Screen8();
        }
    }

    #region Stage 1 methods
    public void ShowStage1Screen1()
    {
        SetActiveAndDisableOthers(Stage1Screen1);
    }

    public void ShowStage1Screen2()
    {
        SetActiveAndDisableOthers(Stage1Screen2);
    }

    public void ShowStage1Screen3()
    {
        SetActiveAndDisableOthers(Stage1Screen3);
    }

    public void ShowStage1Screen4()
    {
        SetActiveAndDisableOthers(Stage1Screen4);
    }

    public void ShowStage1Screen5()
    {
        SetActiveAndDisableOthers(Stage1Screen5);
    }

    public void ShowStage1Screen6()
    {
        SetActiveAndDisableOthers(Stage1Screen6);
    }

    public void ShowStage1Screen7()
    {
        SetActiveAndDisableOthers(Stage1Screen7);
    }

    public void ShowStage1Screen8()
    {
        SetActiveAndDisableOthers(Stage1Screen8);
    }

    public void EndStage1()
    {
        Stage1Screen8.SetActive(false);
    }

    #endregion
    #region Stage 2 methods

    public void ShowStage2Screen1()
    {
        SetActiveAndDisableOthers(Stage2Screen1);
        Stage2Done = true;
    }

    public void ShowStage2Screen2()
    {
        SetActiveAndDisableOthers(Stage2Screen2);
    }

    public void ShowStage2Screen3()
    {
        SetActiveAndDisableOthers(Stage2Screen3);
    }

    public void ShowStage2Screen4()
    {
        SetActiveAndDisableOthers(Stage2Screen4);
    }

    public void ShowStage2Screen5()
    {
        SetActiveAndDisableOthers(Stage2Screen5);
    }


    #endregion
    #region Stage 3 methods

    public void ShowStage3Screen1()
    {
        SetActiveAndDisableOthers(Stage3Screen1);
        Stage3Done = true;
    }

    public void ShowStage3Screen2()
    {
        SetActiveAndDisableOthers(Stage3Screen2);
    }

    public void closeScreen2()
    {
        Stage3Screen2.SetActive(false);
    }
    public void ShowStage3Screen3()
    {
        SetActiveAndDisableOthers(Stage3Screen3);
        marketplace = true;
    }

    public void closeScreen4()
    {
        Stage3Screen4.SetActive(false);
    }

    public void ShowStage3Screen4()
    {
        SetActiveAndDisableOthers(Stage3Screen4);
    }

    public void ShowStage3Screen5()
    {
        SetActiveAndDisableOthers(Stage3Screen5);
        bought = true;
    }

        public void closeScreen5()
    {
        Stage3Screen5.SetActive(false);
    }

    #endregion
    #region Stage 4 methods

    // Stage 4 methods
    public void ShowStage4Screen1()
    {
        SetActiveAndDisableOthers(Stage4Screen1);
    }

    public void ShowStage4Screen2()
    {
        SetActiveAndDisableOthers(Stage4Screen2);
    }

    public void ShowStage4Screen3()
    {
        SetActiveAndDisableOthers(Stage4Screen3);
    }

    public void ShowStage4Screen4()
    {
        SetActiveAndDisableOthers(Stage4Screen4);
    }

    public void ShowStage4Screen5()
    {
        SetActiveAndDisableOthers(Stage4Screen5);
    }

    public void ShowStage4Screen6()
    {
        SetActiveAndDisableOthers(Stage4Screen6);
    }

    public void ShowStage4Screen7()
    {
        SetActiveAndDisableOthers(Stage4Screen7);
    }

    public void closeScreen7()
    {
        Stage4Screen7.SetActive(false);
    }

    public void ShowStage4Screen8()
    {
        SetActiveAndDisableOthers(Stage4Screen8);
    }

    #endregion

    // Helper method to activate the given screen and disable others
    private void SetActiveAndDisableOthers(GameObject screen)
    {
        // Deactivate all screens
        DeactivateAllScreens();

        // Activate the given screen
        screen.SetActive(true);
    }

    // Helper method to deactivate all screens
    private void DeactivateAllScreens()
    {
        DeactivateStageScreens(
            Stage1Screen1, Stage1Screen2, Stage1Screen3, Stage1Screen4,
            Stage1Screen5, Stage1Screen6, Stage1Screen7, Stage1Screen8,
            Stage2Screen1, Stage2Screen2, Stage2Screen3, Stage2Screen4,
            Stage2Screen5,
            Stage3Screen1, Stage3Screen2, Stage3Screen3, Stage3Screen4,
            Stage3Screen5,
            Stage4Screen1, Stage4Screen2, Stage4Screen3, Stage4Screen4,
            Stage4Screen5, Stage4Screen6, Stage4Screen7, Stage4Screen8
        );
    }

    // Helper method to deactivate screens of a stage
    private void DeactivateStageScreens(params GameObject[] screens)
    {
        foreach (var screen in screens)
        {
            if (screen != null)
            {
                screen.SetActive(false);
            }
        }
    }
}
