using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Random = System.Random;

public class Hp : MonoBehaviour
{
    private Vector3 randomPos;
    private Random random=new Random();
    public GameObject Energy;
    void Start()
    {
        InvokeRepeating("Spawn",2f,6f);
    }


    void Spawn()
    {
        randomPos = new Vector3(random.Next(-9,10),0.2f,random.Next(1,12));
        Instantiate(Energy,randomPos,Energy.transform.rotation);
    }
}
