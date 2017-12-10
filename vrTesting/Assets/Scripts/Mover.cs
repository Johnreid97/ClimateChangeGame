using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public RailPoint railPoints;

    int currentSeg;
    public float transition;
    public bool isCompleted = false;
    float speed = 1;
    

    public Coroutine startMoving;

    void Update()
    {
        if (!railPoints)
        {
            return;
        }

        if (isCompleted == false)
        {
            MoveObject();
        }
    }

    void MoveObject()
    {

        transition += Time.deltaTime / speed;

        if (transition > 1)
        {
            transition = 0;
            currentSeg++;
        }
        else if (transition < 0)
        {
            transition = 1;
            currentSeg--;
        }

        transform.position = railPoints.Position(currentSeg, transition);

        if (railPoints.p1 == railPoints.lastNode || railPoints.p2 == railPoints.lastNode)
        {
            isCompleted = true;
            transform.position = transform.position;
            //Destroy(gameObject);
        }
    }

   
}
