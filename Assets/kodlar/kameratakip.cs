using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour

{
    public Transform top;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(top.position.y>transform.position.y)
        {
            transform.position=new Vector3(transform.position.x,top.position.y,transform.position.z);
        }
    }
}
