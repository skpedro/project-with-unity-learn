using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Random = System.Random;

public class Spawn : MonoBehaviour
{
    public GameObject[] Animals;
    private Random random = new Random();
    private int randomIndex;
    private Vector3 randomPos;
    void Start()
    {
        InvokeRepeating("VerticulSpawnAnimal", 2f, 2f);
        InvokeRepeating("HorizontalSpawnAnimal", 3f, 2f);
    }
    void VerticulSpawnAnimal()
    {
        randomPos = new Vector3(random.Next(-9, 10), 0, 20);
        randomIndex = random.Next(0, Animals.Length);
        Instantiate(Animals[randomIndex], randomPos, Animals[randomIndex].transform.rotation);
    }
    void HorizontalSpawnAnimal()
    {
        Vector3 rotation = new Vector3(0, 90, 0);
        randomPos = new Vector3(-16, 0, random.Next(0, 12));
        randomIndex = random.Next(0, Animals.Length);
        Instantiate(Animals[randomIndex], randomPos, Quaternion.Euler(rotation));
    }
}
