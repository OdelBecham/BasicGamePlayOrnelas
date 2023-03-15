using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float xspawnInterval = 3f;
    private float spawnRangeZ = 10;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("RightSpawnRandomAnimal", startDelay, xspawnInterval);
        InvokeRepeating("LeftSpawnRandomAnimal", startDelay, xspawnInterval);
    }
    
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
    }
    void RightSpawnRandomAnimal()
    {
        Vector3 spawnxPos = new Vector3(22, 0, (Random.Range(-spawnRangeZ, spawnRangeZ)));
        int animalIndex = Random.Range(3,5);
        Instantiate(animalPrefabs[animalIndex], spawnxPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void LeftSpawnRandomAnimal()
    {
        Vector3 spawnzPos = new Vector3(-22, 0, (Random.Range(-spawnRangeZ, spawnRangeZ)));
        int animalIndex = Random.Range(6,8);
        Instantiate(animalPrefabs[animalIndex], spawnzPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
