using UnityEngine;
using UnityEngine.EventSystems;

public class GameSelectManager : MonoBehaviour
{
    // Reference to the prefab containing UI panel for each game
    public GameObject gamePrefab;

    // Reference to the viewport GameObject
    public Transform viewport;

    // Reference to the GameData prefab variant
    public GameData gameDataPrefab;

    // Wrapper method to create a new game with input obtained from other sources
    public void CreateNewGameWithInput()
    {
        // Obtain character name and creation date from PlayerPrefs
        string characterName = PlayerPrefs.GetString("CharacterName", "DefaultCharacterName");
        string creationDate = PlayerPrefs.GetString("CreationDate", "DefaultCreationDate");

        // Call CreateNewGame with obtained input
        CreateNewGame(characterName, creationDate);
    }


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

        // Add event trigger for scale animation
        AddScaleAnimationEventTrigger(newGame);
    }

    // Method to add event trigger for scale animation to the instantiated game
    private void AddScaleAnimationEventTrigger(GameObject game)
    {
        // Get the Event Trigger component of the new game panel
        EventTrigger eventTrigger = game.GetComponent<EventTrigger>();
        if (eventTrigger == null)
        {
            // Add Event Trigger component if not already added
            eventTrigger = game.AddComponent<EventTrigger>();
        }

        // Add Pointer Enter event
        EventTrigger.Entry pointerEnterEntry = new EventTrigger.Entry();
        pointerEnterEntry.eventID = EventTriggerType.PointerEnter;
        pointerEnterEntry.callback.AddListener((data) => { game.GetComponent<ScaleAnim>().ScaleUp(); });
        eventTrigger.triggers.Add(pointerEnterEntry);

        // Add Pointer Exit event
        EventTrigger.Entry pointerExitEntry = new EventTrigger.Entry();
        pointerExitEntry.eventID = EventTriggerType.PointerExit;
        pointerExitEntry.callback.AddListener((data) => { game.GetComponent<ScaleAnim>().ScaleDown(); });
        eventTrigger.triggers.Add(pointerExitEntry);
    }

}

