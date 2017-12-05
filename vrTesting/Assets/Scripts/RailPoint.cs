using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor;
#endif



[ExecuteInEditMode]
public class RailPoint : MonoBehaviour
{


    public Transform[] nodes;
    public Vector3 firstNode;

    public GameObject beingMoved;
    //int whatLine;
    //float whereOnLine;

    public Vector3 p1;
    public Vector3 p2;
    bool isTravelling;
    Quaternion q1;
    Quaternion q2;

    // Use this for initialization
    void Start()
    {
        nodes = GetComponentsInChildren<Transform>();
        firstNode = nodes[nodes.Length + 1].position;
        //p1 = nodes[whatLine + 1].position;
        //p2 = nodes[whatLine + 2].position;
        //StartCoroutine(Lerp());

    }

    void Update()
    {


    }

    public Vector3 Position(int currentLine, float whereOnLine)
    {

        p1 = nodes[currentLine + 1].position;
        p2 = nodes[currentLine + 2].position;

        return Vector3.Lerp(p1, p2, whereOnLine);

    }

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        for (int i = 1; i < nodes.Length - 1; i++)
        {
            Handles.DrawDottedLine(nodes[i].position, nodes[i + 1].position, 3.0f);
        }
    }
#endif
}

