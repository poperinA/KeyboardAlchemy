using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private void Start()
    {
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


    public void GoToGame()
    {
        SceneManager.LoadScene("Room");
    }
}
