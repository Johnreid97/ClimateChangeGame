using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public RailPoint railPoints;

    int currentSeg;
    float Transition;
    bool isCompleted = false;
    float speed = 2;

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
        Transition += Time.deltaTime * 1 / speed;

        if (Transition > 1)
        {
            Transition = 0;
            currentSeg++;
        }
        else if (Transition < 0)
        {
            Transition = 1;
            currentSeg--;
        }
        transform.position = railPoints.Position(currentSeg, Transition);

        if (transform.position == railPoints.lastNode.position)
        {
            isCompleted = true;
        }
    }
}
