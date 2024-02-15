using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    // Singleton instance of the AudioManager
    private static AudioManager instance;

    // Arrays of Sound objects
    public Sound[] musicSounds, sfxSounds;

    // Audio sources
    public AudioSource musicSource, sfxSource;

    // Public property to access the singleton instance
    public static AudioManager Instance
    {
        get { return instance; }
    }

    // Awake method to set up the Singleton pattern
    private void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If no instance exists, set this as the instance
            instance = this;

            // Ensure that this GameObject persists across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If another instance exists, destroy this object
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //// Retrieve the current scene
        //Scene currentScene = SceneManager.GetActiveScene();

        //// Get the name of the current scene
        //string sceneName = currentScene.name;

        //// Check the current scene and play appropriate music
        //if (sceneName == "Start")
        //{
        //    PlayMusic("StartTheme");
        //}
        //else if (sceneName == "GameScene")
        //{
        //    PlayMusic("GameplayTheme");
        //}
    }

    // Play music based on the name
    public void PlayMusic(string name)
    {
        // Find the Sound object with the specified name in the musicSounds array
        Sound s = Array.Find(musicSounds, x => x.name == name);

        // Check if the sound is found
        if (s == null)
        {
            Debug.Log("Music sound not found");
        }
        else
        {
            // Set the clip and play the music
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    // Play SFX based on the name
    public void PlaySFX(string name)
    {
        // Find the Sound object with the specified name in the sfxSounds array
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        // Check if the sound is found
        if (s == null)
        {
            Debug.Log("SFX sound not found");
        }
        else
        {
            // Play the sound once (as it is an SFX)
            sfxSource.PlayOneShot(s.clip);
        }
    }
}
