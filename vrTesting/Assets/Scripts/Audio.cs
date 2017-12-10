using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip audioClip, audioClip2, audioClip3, audioClip4, audioClip5;
    public int soundCounter = 0;
    public bool isPlaying = false;
    
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        CheckForAudio();
        CheckInitialSound();
        LoadNextScene();
    }

    void CheckInitialSound()
    {
        if (audioSource.isPlaying)
        {
            isPlaying = true;

        }
        if (!audioSource.isPlaying)
        {

            isPlaying = false;
        }

    }

    void LoadNextScene()
    {
        if (soundCounter ==6 && !audioSource.isPlaying)
        {
        SceneManager.LoadScene("Savannah", LoadSceneMode.Single);
    }
    }
    

    void CheckForAudio()
    {
        switch (soundCounter)
        {
            case 0:
                if (!audioSource.isPlaying)
                {
                    soundCounter = 1;
                }
                break;
            case 1:
                if (audioSource.isPlaying && audioSource.clip == audioClip)
                    soundCounter++;
                
                
                break;
            case 2:
                if (audioSource.isPlaying && audioSource.clip == audioClip2)
                    soundCounter++;
                break;
            case 3:
                if (audioSource.isPlaying && audioSource.clip == audioClip3)
                    soundCounter++;
                break;
            case 4:
                if (audioSource.isPlaying && audioSource.clip == audioClip4)
                    soundCounter++;
                break;
            case 5:
                if (audioSource.isPlaying && audioSource.clip == audioClip5)
                    soundCounter++;
                break;
        }
    }
}
