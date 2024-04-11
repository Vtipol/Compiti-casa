using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camscript : MonoBehaviour
{

    void Start()
    {
        
    }

    public Transform target;
    void Update()
    {
        transform.position = target.transform.position + new Vector3(0, 1, -6);
    }
}
