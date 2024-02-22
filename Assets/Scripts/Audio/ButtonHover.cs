using UnityEngine;

public class ButtonHover : MonoBehaviour
{
    // AudioManager instance
    private AudioManager audioManager;

    private void Start()
    {
        // Get the AudioManager instance
        audioManager = AudioManager.Instance;
    }

    public void PlayHoverSound()
    {
        // Play the hover sound
        AudioManager.Instance.PlaySFX("BtnHover");
    }

    public void PlayClickSound()
    {
        // Play the click sound
        AudioManager.Instance.PlaySFX("BtnClick");
    }
}
