using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader1 : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    public void GoToGame()
    {
        LoadNextLevel();
        AudioManager.Instance.PlaySFX("BtnClick");
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
