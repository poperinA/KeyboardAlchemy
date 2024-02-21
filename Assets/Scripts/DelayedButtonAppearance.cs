using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DelayedButtonAppearance : MonoBehaviour
{
    public GameObject screen7;
    public GameObject button;
    public Button buttonToAppear;
    public float delayInSeconds = 3f;

    private void Start()
    {
        // Start the coroutine to delay the appearance of the button
        if (screen7.activeInHierarchy ==  true)
        {
            Debug.Log("hello");
            button.SetActive(false);
            StartCoroutine(DelayButtonAppearance());
        }
        
    }

    IEnumerator DelayButtonAppearance()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delayInSeconds);

        // Enable the button after the delay
        if (buttonToAppear != null)
        {
            buttonToAppear.gameObject.SetActive(true);
        }
    }
}
