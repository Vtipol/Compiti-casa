using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
   
    void Start()
    {
        
    }
    public Transform teleportTarget;
    public GameObject Sphere;
void OnTriggerEnter()
    {
        Sphere.transform.position = teleportTarget.transform.position;
    }
    void Update()
    {
        
    }
}
