using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader1 : MonoBehaviour
{
    public GameObject Black;
    public Animator transition;
    public float transitionTime;

    void Start()
    {
        // Get the name of the current scene
        string sceneName = SceneManager.GetActiveScene().name;

        // Check if the scene name is "Room"
        if (sceneName == "Room")
        {
            // Enable the black GameObject
            Black.SetActive(true);
        }
    }
    public void GoToGame()
    {
        if(Black.activeInHierarchy == false)
        {
            Black.SetActive(true);
            LoadNextLevel();
            AudioManager.Instance.PlaySFX("BtnClick");
        }

    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel("Room"));
    }

    IEnumerator LoadLevel(string sceneName)
    {
        //Play anim
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(sceneName);
    }
}
