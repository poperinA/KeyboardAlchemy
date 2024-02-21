using UnityEngine;
using TMPro;

public class CharacterSelect : MonoBehaviour
{
    public TextMeshProUGUI characterNameInput;
    public GameObject Megan;
    public GameObject David;
    public GameSelectManager gameSelectManager; // Reference to the GameSelectManager

    private void Start()
    {
        // Find the GameSelectManager in the scene
        gameSelectManager = FindObjectOfType<GameSelectManager>();
    }

    public void showMegan()
    {
        if (David.activeInHierarchy)
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

    public void SavePlayerInput()
    {
        string characterName = characterNameInput.text;
        string chosenGender = "";

        // Determine chosen gender
        if (Megan.activeInHierarchy)
        {
            chosenGender = "Female";
        }
        else if (David.activeInHierarchy)
        {
            chosenGender = "Male";
        }
        else
        {
            return; // Exit the method if gender is not chosen
        }

        Debug.Log(chosenGender);
        // Save player input
        PlayerPrefs.SetString("CharacterName", characterName);
        PlayerPrefs.SetString("PlayerGender", chosenGender);
        PlayerPrefs.SetString("CreationDate", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

        // Create new game using GameSelectManager
        gameSelectManager.CreateNewGameWithInput();
    }
}
