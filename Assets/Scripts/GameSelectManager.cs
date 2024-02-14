using UnityEngine;
using UnityEngine.EventSystems;

public class GameSelectManager : MonoBehaviour
{
    public GameObject gamePrefab; // Reference to the prefab containing UI panel for each game
    public Transform viewport; // Reference to the viewport GameObject
    public GameObject gameDataPrefab; // Reference to the Prefab Variant containing the GameData

    private static GameSelectManager instance;

    private void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If not, set this as the instance
            instance = this;

            // Make the GameObject persist through scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this GameObject
            Destroy(gameObject);
        }
    }

    public static GameSelectManager GetInstance()
    {
        return instance;
    }

    public void CreateNewGame(string characterName, string creationDate)
    {
        // Instantiate the game prefab
        GameObject newGame = Instantiate(gamePrefab, viewport);

        // Instantiate the game data prefab variant
        GameObject newGameDataObject = Instantiate(gameDataPrefab);

        // Get the GameData component from the instantiated game data prefab variant
        GameData newGameData = newGameDataObject.GetComponent<GameData>();

        // Populate the new GameData instance with character name and creation date
        newGameData.characterName = characterName;
        newGameData.creationDate = creationDate;

        // Set the GameData instance for the GameDisplay component
        newGame.GetComponent<GameDisplay>().game = newGameData;

        // Get the Event Trigger component of the new game panel
        EventTrigger eventTrigger = newGame.GetComponent<EventTrigger>();
        if (eventTrigger == null)
        {
            // Add Event Trigger component if not already added
            eventTrigger = newGame.AddComponent<EventTrigger>();
        }

        // Add Pointer Enter event
        EventTrigger.Entry pointerEnterEntry = new EventTrigger.Entry();
        pointerEnterEntry.eventID = EventTriggerType.PointerEnter;
        pointerEnterEntry.callback.AddListener((data) => { newGame.GetComponent<ScaleAnim>().ScaleUp(); });
        eventTrigger.triggers.Add(pointerEnterEntry);

        // Add Pointer Exit event
        EventTrigger.Entry pointerExitEntry = new EventTrigger.Entry();
        pointerExitEntry.eventID = EventTriggerType.PointerExit;
        pointerExitEntry.callback.AddListener((data) => { newGame.GetComponent<ScaleAnim>().ScaleDown(); });
        eventTrigger.triggers.Add(pointerExitEntry);
    }
}
