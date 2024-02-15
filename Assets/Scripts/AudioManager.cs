using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    //singleton instance of the AudioManager
    public static AudioManager Instance;

    //arrays of Sound objects
    public Sound[] musicSounds, sfxSounds;

    //audio sources
    public AudioSource musicSource, sfxSource;


    //awake method to set up the Singleton pattern
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
        //retrieve the current scene
        Scene currentScene = SceneManager.GetActiveScene();

        //get the name of the current scene
        string sceneName = currentScene.name;

        //check the current scene and play appropriate music
        if (sceneName == "Start")
        {
            playMusic("StartTheme");
        }
        else if (sceneName == "GameScene")
        {
            playMusic("GameplayTheme");
            playSFX("dogDefault");
        }
    }

    //play music based on the name
    public void playMusic(string name)
    {
        //find the Sound object with the specified name in the musicSounds array
        Sound s = Array.Find(musicSounds, x => x.name == name);

        //check if the sound is found
        if (s == null)
        {
            Debug.Log("Music sound not found");
        }
        else
        {
            //set the clip and play the music
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    //play SFX based on the name
    public void playSFX(string name)
    {
        //find the Sound object with the specified name in the sfxSounds array
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        //check if the sound is found
        if (s == null)
        {
            Debug.Log("SFX sound not found");
        }
        else
        {
            //play the sound once (as it is an sfx)
            sfxSource.PlayOneShot(s.clip);
        }
    }
}
