using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour {
    public  float timeUntilNextScene = 30.0f;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()

    {
        timeUntilNextScene -= Time.deltaTime;
        if (timeUntilNextScene <=0)
        {
            
            SceneManager.LoadScene("Rainforest", LoadSceneMode.Single);
        }
	}
}
