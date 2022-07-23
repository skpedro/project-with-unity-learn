using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(1,4));
    }

  
    void SpawnRandomBall ()
    {       
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
       
        Instantiate(ballPrefabs[Random.Range(0,3)], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
