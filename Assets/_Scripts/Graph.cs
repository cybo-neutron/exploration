using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public int height;
    public int width;

    public Node[,] graphData = new Node[0,0];

    // Start is called before the first frame update
    void Start()
    {
        graphData = new Node[height,width];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
