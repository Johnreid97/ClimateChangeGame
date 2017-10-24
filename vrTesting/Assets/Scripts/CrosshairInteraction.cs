using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairInteraction : MonoBehaviour {

   public float loadingTime = 3f;

    public float timer;
    bool staring = false;
    Coroutine objectLoading;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        

    }
    
    //public void DeleteCube()
    //{
    //    if (staring)
    //    {
    //        Destroy(this.gameObject);
    //        print("Working");
            
    //    }

        
    //}
    public void PointerEnter()
    {
        staring = true;
        objectLoading = StartCoroutine(LoadingObject());
            
    }

    public void PointerExit()
    {
       
        if (objectLoading != null)
        {
            
            StopCoroutine(objectLoading);
            timer = 0f;
        }
    }


    public IEnumerator LoadingObject()
    {
        timer = 0f;

        while (timer < loadingTime)
        {
            timer += Time.deltaTime;
           
            yield return null;
            if (timer > loadingTime )
            {
                Destroy(this.gameObject);
            }
        }

        
    }
    
}
