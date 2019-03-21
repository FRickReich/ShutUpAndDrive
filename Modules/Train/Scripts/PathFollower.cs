using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    Node[] pathNodes;
    public GameObject train;

    public float moveSpeed;
    float timer;

    int currentNode;

    static Vector3 currentPositionHolder;

    // Start is called before the first frame update
    void Start()
    {
        pathNodes = GetComponentsInChildren<Node>();

        CheckNode();
    }

    void DrawLine()
    {
        for (int i = 0; i < pathNodes.Length; i++)
        {
            if(i < pathNodes.Length - 1)
            { 
                Debug.DrawLine(pathNodes[i].transform.position, pathNodes[i + 1].transform.position, Color.blue);
            }
        }
    }

    void CheckNode()
    {
        if(currentNode < pathNodes.Length - 1)
        { 
            timer = 0;
            currentPositionHolder = pathNodes[currentNode].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        DrawLine();

        timer += Time.deltaTime * moveSpeed;

        if(train.transform.position != currentPositionHolder)
        {
            train.transform.position = Vector3.Lerp(train.transform.position, currentPositionHolder, timer);
        }
        else 
        {
            if(currentNode < pathNodes.Length - 1) { 
                currentNode++;
                CheckNode();
            }
        }
    }
}
