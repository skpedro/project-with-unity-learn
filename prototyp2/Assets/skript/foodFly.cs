using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodFly : MonoBehaviour
{
     public float speed=7;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
