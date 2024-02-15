using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject Options;

    public void ToggleOptions()
    {
        if (Options != null)
        {
            bool isActive = Options.activeSelf;

            Options.SetActive(!isActive);
        }
    }
}
