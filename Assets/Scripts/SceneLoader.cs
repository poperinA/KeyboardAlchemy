using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        // Prevent this GameObject from being destroyed when loading a new scene
        DontDestroyOnLoad(gameObject);

        // Load the "Main Menu" scene
        SceneManager.LoadScene("Main Menu");
    }
}
