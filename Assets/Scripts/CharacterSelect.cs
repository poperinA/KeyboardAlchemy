using System;
using UnityEngine;
using TMPro;

public class CharacterSelect : MonoBehaviour
{
    public TextMeshProUGUI characterNameInput;
    public string chosenGender = "none";

    public GameObject Megan;
    public GameObject David;

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
            Debug.Log("Choose gender");
            return; // Exit the method if gender is not chosen
        }

        // Get current date and time
        string creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Log the inputs
        Debug.Log("Character Name: " + characterName);
        Debug.Log("Chosen Gender: " + chosenGender);
        Debug.Log("Creation Date: " + creationDate);

        // Save player input
        PlayerPrefs.SetString("CharacterName", characterName);
        PlayerPrefs.SetString("Gender", chosenGender);
        PlayerPrefs.SetString("CreationDate", creationDate);
    }

}
