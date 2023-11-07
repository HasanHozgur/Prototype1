using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX = 10.0f;
    private float spawnPositionZ = 100.0f;
    private float startDelay = 1.0f;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //For spawning random cars
    void SpawnRandomCar()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        int carIndex = Random.Range(0, carPrefabs.Length);

        Instantiate(carPrefabs[carIndex], spawnPosition, carPrefabs[carIndex].transform.rotation);
    }
}
