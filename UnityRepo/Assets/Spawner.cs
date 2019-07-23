using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float SpawnRate = 1f;

    public GameObject hexagonPrefab;

    private float NextTimeToSpawn = 1f;


    void Update()
    {
        if (Time.time >= NextTimeToSpawn) {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            NextTimeToSpawn = Time.time + 1f / SpawnRate;
        }        
    }
}
