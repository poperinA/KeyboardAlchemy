using UnityEngine;
using UnityEngine.EventSystems;

public class GameSelectManager : MonoBehaviour
{
    public GameObject gamePrefab; // Reference to the prefab containing UI panel for each game
    public Transform viewport; // Reference to the viewport GameObject

    public void CreateNewGame()
    {
        // Instantiate the game prefab
        GameObject newGame = Instantiate(gamePrefab, viewport);

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
