using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeView : MonoBehaviour
{
    public Color color;
    public SpriteRenderer render;

    void Start()
    {
        render.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
