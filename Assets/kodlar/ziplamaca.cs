using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplamaca : MonoBehaviour
{
    
    public Rigidbody2D top;
    public float ziplamahiziy;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            top.velocity=Vector2.up*ziplamahiziy;
        }

    }
}
