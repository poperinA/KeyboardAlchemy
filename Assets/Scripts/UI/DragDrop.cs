using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private Vector2 originalPosition;
    public GameObject originalParent;
    public GameObject newParent; // Assign the new parent in the Inspector

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = rectTransform.anchoredPosition; // Store the original position
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (newParent != null)
        {
            transform.SetParent(newParent.transform, false); // Set the new parent for dragging
        }
        else
        {
            Debug.LogError("New parent not assigned!");
        }

        // Center the object to the cursor
        rectTransform.SetAsLastSibling(); // Move the object to the front
        rectTransform.position = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Move the object with the cursor
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Return the item to its original parent and position after dragging
        transform.SetParent(originalParent.transform, false);
        rectTransform.anchoredPosition = originalPosition;

        // Check if the item is dropped onto an item slot
        ItemSlot itemSlot = eventData.pointerCurrentRaycast.gameObject.GetComponent<ItemSlot>();
        if (itemSlot != null)
        {
            // Notify the item slot that an item has been dropped onto it
            itemSlot.OnDrop(eventData);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Implement any additional logic when the item is clicked
    }
}
