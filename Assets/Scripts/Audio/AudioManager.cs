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
        // Ensure only one instance of AudioManager exists
        if (Instance == null)
        {
            // Set this as the instance if no instance exists
            Instance = this;
            DontDestroyOnLoad(gameObject); // Don't destroy AudioManager when loading new scenes
        }
        else
        {
            // Destroy this object if another instance exists
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        PlayMusic("StartTheme");
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Room")
        {
            PlayMusic("GameplayTheme");
        }

        if (scene.name == "Main Menu")
        {
            PlayMusic("StartTheme");
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
        }
    }
}
