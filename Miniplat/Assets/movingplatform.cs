using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public Transform pointA; 
    public Transform pointB; 
    public float speed = 2.0f; 
    private bool movingToB = true; 

    void Update()
    {
        if (movingToB)
        { 
            transform.Translate((pointB.position - transform.position).normalized * speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, pointB.position) < 0.1f)
            {
                movingToB = false; 
            }
        }
        else
        {  
          transform.Translate((pointA.position - transform.position).normalized * speed * Time.deltaTime); 
            if (Vector3.Distance(transform.position, pointA.position) < 0.1f)
            {
                movingToB = true; 
            }
        }
    }
}
