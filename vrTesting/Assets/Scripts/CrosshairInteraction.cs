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
                        break;
                    case "RainforestUI":
                        break;
                    case "SceneSkip":
                        SceneManager.LoadScene("Savannah", LoadSceneMode.Single);
                        break;
                    case "SceneSkip2":
                        SceneManager.LoadScene("Rainforest", LoadSceneMode.Single);
                        break;
                }
                
            }
        }

        
    }
    
}
