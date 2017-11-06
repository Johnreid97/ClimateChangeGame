using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavannaLoadScene : MonoBehaviour {
    float timeUntilNextScene = 172f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeUntilNextScene -= Time.deltaTime;
        if (timeUntilNextScene <= 0)
        {

            SceneManager.LoadScene("Savannah", LoadSceneMode.Single);
        }
    }
}
