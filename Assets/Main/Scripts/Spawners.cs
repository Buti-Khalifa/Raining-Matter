using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public GameObject[] items;
    // Spawn Points
    public Transform[] spawnPoints;

    public float spawnTime = 1f;
    public float spawnDelay = 1f;

    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int itemIndex = Random.Range(0, items.Length);

        Instantiate(items[itemIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }


}
