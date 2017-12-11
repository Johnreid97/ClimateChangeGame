using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip audioClip, audioClip2, audioClip3, audioClip4, audioClip5;
    public int soundCounter = 0;
    public bool isPlaying = false;
    public Behaviour halo, halo2, halo3, halo4, halo5;
    
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
                    halo.enabled = true;
                }
                break;
            case 1:
                if (audioClip != null)
                {
                    if (audioSource.isPlaying && audioSource.clip == audioClip)
                        soundCounter++;
                }
                
                break;
            case 2:
                if (audioClip2 != null)
                {
                    if (audioSource.isPlaying && audioSource.clip == audioClip2)
                    {
                        soundCounter++;

                    }
                    halo2.enabled = true;
                }

                break;
            case 3:
                if (audioClip3 != null)
                {
                    if (audioSource.isPlaying && audioSource.clip == audioClip3)
                    {
                        soundCounter++;

                    }
                    halo2.enabled = false;
                    halo3.enabled = true;
                }
                break;
            case 4:
                if (audioClip4 != null)
                {
                    if (audioSource.isPlaying && audioSource.clip == audioClip4)
                    {
                        soundCounter++;
                    }
                    halo3.enabled = false;
                    halo4.enabled = true;
                }
                break;
            case 5:
                if (audioClip5 != null)
                {
                    if (audioSource.isPlaying && audioSource.clip == audioClip5)
                    {
                        soundCounter++;

                    }
                    halo4.enabled = false;
                    halo5.enabled = true;
                }
                break;
        }
    }
}
