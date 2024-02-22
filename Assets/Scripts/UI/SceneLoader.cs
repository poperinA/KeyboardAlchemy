using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime;

    private void Start()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Play()
    {
        SceneManager.LoadScene("Game Select");
        AudioManager.Instance.PlaySFX("BtnClick");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
        AudioManager.Instance.PlaySFX("BtnClick");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
        AudioManager.Instance.PlaySFX("BtnClick");
    }

    public void BackToGame()
    {
        SceneManager.LoadScene("Room");
        AudioManager.Instance.PlaySFX("BtnClick");
    }
}
