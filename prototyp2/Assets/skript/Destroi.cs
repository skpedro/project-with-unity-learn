using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroi : MonoBehaviour
{
    float rengForward=40;
    float rengDown=-15;
    float rengeX = 30;

    void Update()
    {
        if (transform.position.z>rengForward) {
            Destroy(gameObject);
            PlayerInterface.Damage();
        }

        if (transform.position.z < rengDown){
            Destroy(gameObject);
        }

        if (transform.position.x>30) {  
            Destroy(gameObject);
        }

    }
}
