using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrosshairInteraction : MonoBehaviour {

   public float loadingTime = 3f;
    bool isPlaying = false;
    public float timer;
    bool staring = false;
    Coroutine objectLoading;
    string tag;
    public Animator animator, animator2, animator3, animator4, animator5;
    public Mover mover;
    public AudioSource sound2, sound3, sound4, sound5, sound6;

    
    // Use this for initialization
    void Start () {
		
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
                    case "Carcass":
                        animator.SetBool("Fly1", true);
                        animator2.SetBool("Fly2", true);
                        animator3.SetBool("Fly3", true);
                        animator4.SetBool("Fly4", true);
                        animator5.SetBool("Fly5", true);
                        break;
                    case "Parrot":
                        animator.SetBool("FlyingBool", true);
                        mover.isCompleted = false;
                        break;
                    case "RainforestUI":
                        break;
                    case "SceneSkip":
                        SceneManager.LoadScene("Savannah", LoadSceneMode.Single);
                        break;
                    case "SceneSkip2":
                        SceneManager.LoadScene("Rainforest", LoadSceneMode.Single);
                        break;
                    case "Sound2":
                        if(isPlaying = false)
                        sound2.Play();
                        break;
                    case "Sound3":
                        if (isPlaying = false)
                            sound3.Play();
                        break;
                    case "Sound4":
                        if (isPlaying = false)
                            sound4.Play();
                        break;
                    case "Sound5":
                        if (isPlaying = false)
                            sound5.Play();
                        break;
                    case "Sound6":
                        if (isPlaying = false)
                            sound6.Play();
                        break;
                }
                
            }
        }

        
    }

    void CheckForAudio()
    {
        switch (tag)
        {
            case "Sound2":
                if(sound2.isPlaying)
                {
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                }
                break;
            case "Sound3":
                if (sound3.isPlaying)
                {
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                };
                break;
            case "Sound4":
                if (sound4.isPlaying)
                {
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                }
                break;
            case "Sound5":
                if (sound5.isPlaying)
                {
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                }
                break;
            case "Sound6":
                if (sound6.isPlaying)
                {
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                }
                break;
        }
    }
}


