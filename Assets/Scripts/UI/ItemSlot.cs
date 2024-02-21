using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public GameObject correctItem;
    public GameObject correspondingImage;
    public GameObject nextItem;
    public GameObject currentSlot;
    public GameObject confirmBtn;

    public void OnDrop(PointerEventData eventData)
    {
        DragDrop draggableItem = eventData.pointerDrag.GetComponent<DragDrop>();
        if (draggableItem != null && draggableItem.gameObject == correctItem)
        {
            // Show the corresponding image
            correspondingImage.SetActive(true);

            // Disable dragging for the correct item
            draggableItem.enabled = false;
            correctItem.SetActive(false);

            // Activate the next item slot for dragging
            if (nextItem != null)
            {
                currentSlot.SetActive(false);
                nextItem.SetActive(true);
                if (nextItem.name == "none")
                {
                    confirmBtn.SetActive(true);
                }
            }

        }
    }
}
