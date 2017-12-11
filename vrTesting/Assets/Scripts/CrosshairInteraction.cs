using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrosshairInteraction : MonoBehaviour {

   public float loadingTime = 3f;
    
    public float timer;
    bool staring = false;
    Coroutine objectLoading;
    string tag;
    public Animator animator, animator2, animator3, animator4, animator5;
    public Mover mover, mover2;
    Audio audio;
    
    
    
    // Use this for initialization
    void Start () {
        audio = GetComponent<Audio>();
        
	}
	
	// Update is called once per frame
	void Update () {

        


    }
    
    
    
    public void LookingAt()
    {
        staring = true;
        tag = gameObject.tag; 
        
        objectLoading = StartCoroutine(TriggerSomething());
        
    }

    public void LookingAway()
    {
       
        if (objectLoading != null)
        {
            
            StopCoroutine(objectLoading);
            timer = 0f;
        }
    }


    public IEnumerator TriggerSomething()
    {
        timer = 0f;

        while (timer < loadingTime)
        {
            timer += Time.deltaTime;

            yield return null;
            if (timer > loadingTime )
            {
                switch (tag)
                {
                  
                    case "Parrot":
                        animator.SetBool("FlyingBool", true);
                        break;
                    case "Parrot2":
                        mover2.isCompleted = true;
                        break;
                    case "SceneSkip":
                        SceneManager.LoadScene("Savannah", LoadSceneMode.Single);
                        break;
                    case "SceneSkip2":
                        SceneManager.LoadScene("Rainforest", LoadSceneMode.Single);
                        break;
                    case "Person":
                        animator.SetBool("Walking", true);
                        break;
                    case "Sound2":
                        if (!audio.isPlaying && audio.soundCounter == 1 )
                        {
                            audio.audioSource.clip = audio.audioClip;
                            audio.audioSource.Play();
                            audio.halo.enabled = false;
                        }
                        

                        break;
                    case "Sound3":
                        if (!audio.isPlaying && audio.soundCounter == 2)
                        {
                            audio.audioSource.clip = audio.audioClip2;
                            audio.audioSource.Play();
                            
                            audio.halo2.enabled = false;
                        }
                        break;
                    case "Sound4":
                        if (!audio.isPlaying && audio.soundCounter == 3)
                        {
                            audio.audioSource.clip = audio.audioClip3;
                            audio.audioSource.Play();
                          
                            audio.halo3.enabled = false;
                        }
                        break;
                    case "Sound5":
                        if (!audio.isPlaying && audio.soundCounter == 4)
                        {
                            audio.audioSource.clip = audio.audioClip4;
                            audio.audioSource.Play();
                            audio.halo4.enabled = false;
                            
                        }
                        break;
                    case "Sound6":
                        if (!audio.isPlaying && audio.soundCounter == 5)
                        {
                            audio.audioSource.clip = audio.audioClip5;
                            audio.audioSource.Play();
                           
                            audio.halo5.enabled = false;
                        }
                        break;
                }
                
            }
        }

        
    }

    
}


