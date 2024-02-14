using UnityEngine;

public class GameSelectManager : MonoBehaviour
{
    // Reference to the prefab containing UI panel for each game
    public GameObject gamePrefab;

    // Reference to the viewport GameObject
    public Transform viewport;

    // Reference to the GameData prefab variant
    public GameData gameDataPrefab;

    // Method to create a new game with input parameters
    public void CreateNewGame(string characterName, string creationDate)
    {
        // Instantiate the game prefab
        GameObject newGame = Instantiate(gamePrefab, viewport);

        // Instantiate the game data prefab variant
        GameData newGameData = Instantiate(gameDataPrefab);

        // Populate the new GameData instance with character name and creation date
        newGameData.characterName = characterName;
        newGameData.creationDate = creationDate;

        // Set the GameData instance for the GameDisplay component
        newGame.GetComponent<GameDisplay>().game = newGameData;

        // Additional initialization logic if needed
    }

    // Wrapper method to create a new game with input obtained from other sources
    public void CreateNewGameWithInput()
    {
        // Obtain character name and creation date from PlayerPrefs
        string characterName = PlayerPrefs.GetString("CharacterName", "DefaultCharacterName");
        string creationDate = PlayerPrefs.GetString("CreationDate", "DefaultCreationDate");

        // Call CreateNewGame with obtained input
        CreateNewGame(characterName, creationDate);
    }
}
