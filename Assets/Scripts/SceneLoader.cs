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

    public void Play()
    {
        SceneManager.LoadScene("Game Select");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void BackToGame()
    {
        SceneManager.LoadScene("Room");
    }

    public void BackToGameSelect()
    {
        SceneManager.LoadScene("Game Select");
    }

    public void CreateGame()
    {
        SceneManager.LoadScene("New Game");
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Room");
    }
}
