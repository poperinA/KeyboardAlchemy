using UnityEngine;
using TMPro;
public class GameDisplay : MonoBehaviour
{
    public GameData game;

    public TextMeshProUGUI CharacterName;
    public TextMeshProUGUI CreationDate;

    public bool hasBeenClicked = false;

    void Start()
    {
        // Verify that the GameData instance is assigned
        if (game != null)
        {
            // Access the character name and creation date
            CharacterName.text = game.characterName;
            CreationDate.text = game.creationDate;
        }
        else
        {
            Debug.LogWarning("GameData instance is not assigned.");
        }
    }

    public void Clicked()
    {
        hasBeenClicked = true;
    }
} 

