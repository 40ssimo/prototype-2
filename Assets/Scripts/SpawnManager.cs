using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 15f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    void Start()
    {

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, 1);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalRight()
    {
        Vector3 spawnPosition = new Vector3(-spawnRangeX, 0, Random.Range(-spawnPosZ, spawnPosZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, new Quaternion(0, 90, 0, 90));
    }
    
    void SpawnRandomAnimalLeft()
    {
        Vector3 spawnPosition = new Vector3(spawnRangeX, 0, Random.Range(-spawnPosZ, spawnPosZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, new Quaternion(0, -90, 0, 90));
    }
}
