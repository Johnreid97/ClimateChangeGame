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
    public Vector3 lastNode;

    public GameObject beingMoved;
    //int whatLine;
    //float whereOnLine;

    public Vector3 node1;
    public Vector3 node2;
    bool isTravelling;
    Quaternion q1;
    Quaternion q2;

    // Use this for initialization
    void Start()
    {
        nodes = GetComponentsInChildren<Transform>();
        lastNode = nodes[nodes.Length -1].position;
        

    }

    void Update()
    {


    }

    public Vector3 Position(int currentLine, float whereOnLine)
    {

            node1 = nodes[currentLine + 1].position;
            node2 = nodes[currentLine + 2].position;

            return Vector3.Lerp(node1, node2, whereOnLine);

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

