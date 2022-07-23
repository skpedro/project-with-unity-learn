using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float intervalSpawning=2;
   
    void Update()
    {
        if (intervalSpawning>=2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                intervalSpawning = 0;
            }
        }       
        intervalSpawning+=Time.deltaTime;
       
    }
}
