using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


    public bool walking = true;
    public GameObject ground;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        StopMovement();

    }


    public void Moving()
    {
        
        if (walking == true)
        {
            transform.position = transform.position + Camera.main.transform.forward * 0.5f * Time.deltaTime;
        }
    }

    public void StopMovement()
    {
        Ray raycast = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(raycast, out hit))
        {
             if (hit.collider.name.Contains("Plane"))
            {
                walking = false;

            }
            else
            {
                walking = true;
            }
        }
    }
}
