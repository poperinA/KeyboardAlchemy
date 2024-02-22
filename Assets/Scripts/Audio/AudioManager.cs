using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            //if no instance exists, set this as the instance
            Instance = this;
        }
        else
        {
            //if another instance exists, destroy this object
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("StartTheme");

        //retrieve the current scene
        Scene currentScene = SceneManager.GetActiveScene();

        //get the name of the current scene
        string sceneName = currentScene.name;
        Debug.Log(sceneName);

        if (sceneName == "Room")
        {
            PlayMusic("GameplayTheme");
        }
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, X => X.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, X => X.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
            Debug.Log("playing sfx");
        }
    }
}
